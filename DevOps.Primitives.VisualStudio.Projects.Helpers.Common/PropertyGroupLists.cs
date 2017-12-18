using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class PropertyGroupLists
    {
        public static MsBuildPropertyGroupList Create(params MsBuildPropertyGroup[] groups)
            => new MsBuildPropertyGroupList(GetListItems(groups));

        private static List<MsBuildPropertyGroupListAssociation> GetListItems(params MsBuildPropertyGroup[] groups)
            => groups.Select(group => new MsBuildPropertyGroupListAssociation(group)).ToList();
    }
}
