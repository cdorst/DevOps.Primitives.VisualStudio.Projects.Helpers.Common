using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class ItemLists
    {
        public static MsBuildItemList Create(params MsBuildItem[] items)
            => new MsBuildItemList(GetListItems(in items));

        private static List<MsBuildItemListAssociation> GetListItems(in MsBuildItem[] items)
            => items.Select(item => new MsBuildItemListAssociation(in item)).ToList();
    }
}
