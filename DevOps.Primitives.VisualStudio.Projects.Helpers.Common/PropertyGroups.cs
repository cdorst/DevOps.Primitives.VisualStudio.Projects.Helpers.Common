namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class PropertyGroups
    {
        public static MsBuildPropertyGroup Create(params MsBuildProperty[] properties)
            => new MsBuildPropertyGroup(
                PropertyLists.Create(properties),
                condition: default(string));
    }
}
