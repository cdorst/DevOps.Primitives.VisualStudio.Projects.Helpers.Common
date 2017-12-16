using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class PropertyLists
    {
        public static MsBuildPropertyList Create(params MsBuildProperty[] properties)
            => new MsBuildPropertyList(GetListItems(properties));

        private static List<MsBuildPropertyListAssociation> GetListItems(params MsBuildProperty[] properties)
            => properties.Select(property => new MsBuildPropertyListAssociation(property)).ToList();
    }
}
