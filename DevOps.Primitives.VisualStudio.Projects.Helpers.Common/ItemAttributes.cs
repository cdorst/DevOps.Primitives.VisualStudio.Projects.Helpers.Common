namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class ItemAttributes
    {
        public static MsBuildItemAttribute Aliases(in string value)
            => new MsBuildItemAttribute(AttributeConstants.Aliases, in value);

        public static MsBuildItemAttribute AutoGen(in string value)
            => new MsBuildItemAttribute(AttributeConstants.AutoGen, in value);

        public static MsBuildItemAttribute CopyToOutputDirectory(in string value)
            => new MsBuildItemAttribute(AttributeConstants.CopyToOutputDirectory, in value);

        public static MsBuildItemAttribute CustomToolNamespace(in string value)
            => new MsBuildItemAttribute(AttributeConstants.CustomToolNamespace, in value);

        public static MsBuildItemAttribute DependentUpon(in string value)
            => new MsBuildItemAttribute(AttributeConstants.DependentUpon, in value);

        public static MsBuildItemAttribute FusionName(in string value)
            => new MsBuildItemAttribute(AttributeConstants.FusionName, in value);

        public static MsBuildItemAttribute Generator(in string value)
            => new MsBuildItemAttribute(AttributeConstants.Generator, in value);

        public static MsBuildItemAttribute Guid(in string value)
            => new MsBuildItemAttribute(AttributeConstants.Guid, in value);

        public static MsBuildItemAttribute HintPath(in string value)
            => new MsBuildItemAttribute(AttributeConstants.HintPath, in value);

        public static MsBuildItemAttribute IsAssembly(in string value)
            => new MsBuildItemAttribute(AttributeConstants.IsAssembly, in value);

        public static MsBuildItemAttribute Isolated(in string value)
            => new MsBuildItemAttribute(AttributeConstants.Isolated, in value);

        public static MsBuildItemAttribute LastGenOutput(in string value)
            => new MsBuildItemAttribute(AttributeConstants.LastGenOutput, in value);

        public static MsBuildItemAttribute LCID(in string value)
            => new MsBuildItemAttribute(AttributeConstants.LCID, in value);

        public static MsBuildItemAttribute Link(in string value)
            => new MsBuildItemAttribute(AttributeConstants.Link, in value);

        public static MsBuildItemAttribute LogicalName(in string value)
            => new MsBuildItemAttribute(AttributeConstants.LogicalName, in value);

        public static MsBuildItemAttribute Name(in string value)
            => new MsBuildItemAttribute(AttributeConstants.Name, in value);

        public static MsBuildItemAttribute Package(in string value)
            => new MsBuildItemAttribute(AttributeConstants.Package, in value);

        public static MsBuildItemAttribute Private(in string value)
            => new MsBuildItemAttribute(AttributeConstants.Private, in value);

        public static MsBuildItemAttribute Project(in string value)
            => new MsBuildItemAttribute(AttributeConstants.Project, in value);

        public static MsBuildItemAttribute PublishState(in string value)
            => new MsBuildItemAttribute(AttributeConstants.PublishState, in value);

        public static MsBuildItemAttribute SpecificVersion(in string value)
            => new MsBuildItemAttribute(AttributeConstants.SpecificVersion, in value);

        public static MsBuildItemAttribute VersionMinor(in string value)
            => new MsBuildItemAttribute(AttributeConstants.VersionMinor, in value);

        public static MsBuildItemAttribute VersionMajor(in string value)
            => new MsBuildItemAttribute(AttributeConstants.VersionMajor, in value);

        public static MsBuildItemAttribute Visible(in string value)
            => new MsBuildItemAttribute(AttributeConstants.Visible, in value);

        public static MsBuildItemAttribute WrapperTool(in string value)
            => new MsBuildItemAttribute(AttributeConstants.WrapperTool, in value);
    }
}
