using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class PropertyGroupLists
    {
        public static MsBuildPropertyGroupList Create(params MsBuildPropertyGroup[] groups)
            => new MsBuildPropertyGroupList(GetListItems(in groups));

        private static List<MsBuildPropertyGroupListAssociation> GetListItems(in MsBuildPropertyGroup[] groups)
            => groups.Select(group => new MsBuildPropertyGroupListAssociation(in group)).ToList();
    }
}
