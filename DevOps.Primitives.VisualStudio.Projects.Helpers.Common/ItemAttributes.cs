namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class ItemAttributes
    {
        public static MsBuildItemAttribute Aliases(string value) => new MsBuildItemAttribute(AttributeConstants.Aliases, value);
        public static MsBuildItemAttribute AutoGen(string value) => new MsBuildItemAttribute(AttributeConstants.AutoGen, value);
        public static MsBuildItemAttribute CopyToOutputDirectory(string value) => new MsBuildItemAttribute(AttributeConstants.CopyToOutputDirectory, value);
        public static MsBuildItemAttribute CustomToolNamespace(string value) => new MsBuildItemAttribute(AttributeConstants.CustomToolNamespace, value);
        public static MsBuildItemAttribute DependentUpon(string value) => new MsBuildItemAttribute(AttributeConstants.DependentUpon, value);
        public static MsBuildItemAttribute FusionName(string value) => new MsBuildItemAttribute(AttributeConstants.FusionName, value);
        public static MsBuildItemAttribute Generator(string value) => new MsBuildItemAttribute(AttributeConstants.Generator, value);
        public static MsBuildItemAttribute Guid(string value) => new MsBuildItemAttribute(AttributeConstants.Guid, value);
        public static MsBuildItemAttribute HintPath(string value) => new MsBuildItemAttribute(AttributeConstants.HintPath, value);
        public static MsBuildItemAttribute IsAssembly(string value) => new MsBuildItemAttribute(AttributeConstants.IsAssembly, value);
        public static MsBuildItemAttribute Isolated(string value) => new MsBuildItemAttribute(AttributeConstants.Isolated, value);
        public static MsBuildItemAttribute LastGenOutput(string value) => new MsBuildItemAttribute(AttributeConstants.LastGenOutput, value);
        public static MsBuildItemAttribute LCID(string value) => new MsBuildItemAttribute(AttributeConstants.LCID, value);
        public static MsBuildItemAttribute Link(string value) => new MsBuildItemAttribute(AttributeConstants.Link, value);
        public static MsBuildItemAttribute LogicalName(string value) => new MsBuildItemAttribute(AttributeConstants.LogicalName, value);
        public static MsBuildItemAttribute Name(string value) => new MsBuildItemAttribute(AttributeConstants.Name, value);
        public static MsBuildItemAttribute Package(string value) => new MsBuildItemAttribute(AttributeConstants.Package, value);
        public static MsBuildItemAttribute Private(string value) => new MsBuildItemAttribute(AttributeConstants.Private, value);
        public static MsBuildItemAttribute Project(string value) => new MsBuildItemAttribute(AttributeConstants.Project, value);
        public static MsBuildItemAttribute PublishState(string value) => new MsBuildItemAttribute(AttributeConstants.PublishState, value);
        public static MsBuildItemAttribute SpecificVersion(string value) => new MsBuildItemAttribute(AttributeConstants.SpecificVersion, value);
        public static MsBuildItemAttribute VersionMinor(string value) => new MsBuildItemAttribute(AttributeConstants.VersionMinor, value);
        public static MsBuildItemAttribute VersionMajor(string value) => new MsBuildItemAttribute(AttributeConstants.VersionMajor, value);
        public static MsBuildItemAttribute Visible(string value) => new MsBuildItemAttribute(AttributeConstants.Visible, value);
        public static MsBuildItemAttribute WrapperTool(string value) => new MsBuildItemAttribute(AttributeConstants.WrapperTool, value);
    }
}
