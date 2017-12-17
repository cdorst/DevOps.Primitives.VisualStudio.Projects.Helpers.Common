using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class ItemAttributeLists
    {
        public static MsBuildItemAttributeList Create(params MsBuildItemAttribute[] attributes)
            => new MsBuildItemAttributeList(GetListItems(attributes));

        private static List<MsBuildItemAttributeListAssociation> GetListItems(params MsBuildItemAttribute[] attributes)
            => attributes.Select(attribute => new MsBuildItemAttributeListAssociation(attribute)).ToList();
    }
}
