using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class ItemGroupLists
    {
        public static MsBuildItemGroupList Create(params MsBuildItemGroup[] groups)
            => new MsBuildItemGroupList(GetListItems(in groups));

        private static List<MsBuildItemGroupListAssociation> GetListItems(in MsBuildItemGroup[] groups)
            => groups.Select(group => new MsBuildItemGroupListAssociation(in group)).ToList();
    }
}
