using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class PropertyLists
    {
        public static MsBuildPropertyList Create(params MsBuildProperty[] properties)
            => new MsBuildPropertyList(GetListItems(in properties));

        private static List<MsBuildPropertyListAssociation> GetListItems(in MsBuildProperty[] properties)
            => properties.Select(property => new MsBuildPropertyListAssociation(in property)).ToList();
    }
}
