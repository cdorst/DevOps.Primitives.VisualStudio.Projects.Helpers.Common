using System.Collections.Generic;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class Items
    {
        public static MsBuildItem COMFileReference(
            string wrapperTool = null,
            string condition = null)
        {
            var attributes = new List<MsBuildItemAttribute>();
            if (!string.IsNullOrWhiteSpace(wrapperTool)) attributes.Add(ItemAttributes.WrapperTool(wrapperTool));
            return new MsBuildItem(ItemConstants.COMFileReference,
                ItemAttributeLists.Create(attributes.ToArray()),
                condition);
        }

        public static MsBuildItem Compile(
            string dependentUpon = null,
            bool? autoGen = null,
            string link = null,
            bool? visible = null,
            string copyToOutputDirectory = null,
            string condition = null)
        {
            var attributes = new List<MsBuildItemAttribute>();
            if (!string.IsNullOrWhiteSpace(dependentUpon)) attributes.Add(ItemAttributes.DependentUpon(dependentUpon));
            if (autoGen != null) attributes.Add(ItemAttributes.AutoGen(autoGen.ToString()));
            if (!string.IsNullOrWhiteSpace(link)) attributes.Add(ItemAttributes.Link(link));
            if (visible != null) attributes.Add(ItemAttributes.Visible(visible.ToString()));
            if (!string.IsNullOrWhiteSpace(copyToOutputDirectory)) attributes.Add(ItemAttributes.CopyToOutputDirectory(copyToOutputDirectory));
            return new MsBuildItem(ItemConstants.Compile,
                ItemAttributeLists.Create(attributes.ToArray()),
                condition);
        }

        public static MsBuildItem COMReference(
            string name = null,
            string guid = null,
            string versionMajor = null,
            string versionMinor = null,
            string lcid = null,
            string wrapperTool = null,
            bool? isolated = null,
            string condition = null)
        {
            var attributes = new List<MsBuildItemAttribute>();
            if (!string.IsNullOrWhiteSpace(name)) attributes.Add(ItemAttributes.Name(name));
            if (!string.IsNullOrWhiteSpace(guid)) attributes.Add(ItemAttributes.Guid(guid));
            if (!string.IsNullOrWhiteSpace(versionMajor)) attributes.Add(ItemAttributes.VersionMajor(versionMajor));
            if (!string.IsNullOrWhiteSpace(versionMinor)) attributes.Add(ItemAttributes.VersionMinor(versionMinor));
            if (!string.IsNullOrWhiteSpace(lcid)) attributes.Add(ItemAttributes.LCID(lcid));
            if (!string.IsNullOrWhiteSpace(wrapperTool)) attributes.Add(ItemAttributes.WrapperTool(wrapperTool));
            if (isolated != null) attributes.Add(ItemAttributes.Isolated(isolated.ToString()));
            return new MsBuildItem(ItemConstants.COMReference,
                ItemAttributeLists.Create(attributes.ToArray()),
                condition);
        }

        public static MsBuildItem Content(
            string generator,
            string lastGenOutput,
            string customToolNamespace,
            string dependentUpon = null,
            string link = null,
            string publishState = null,
            bool? isAssembly = null,
            bool? visible = null,
            string copyToOutputDirectory = null,
            string condition = null)
        {
            var attributes = new List<MsBuildItemAttribute>();
            attributes.Add(ItemAttributes.Generator(generator));
            attributes.Add(ItemAttributes.LastGenOutput(lastGenOutput));
            attributes.Add(ItemAttributes.CustomToolNamespace(customToolNamespace));
            if (!string.IsNullOrWhiteSpace(dependentUpon)) attributes.Add(ItemAttributes.DependentUpon(dependentUpon));
            if (!string.IsNullOrWhiteSpace(link)) attributes.Add(ItemAttributes.Link(link));
            if (!string.IsNullOrWhiteSpace(publishState)) attributes.Add(ItemAttributes.PublishState(publishState));
            if (isAssembly != null) attributes.Add(ItemAttributes.IsAssembly(isAssembly.ToString()));
            if (visible != null) attributes.Add(ItemAttributes.Visible(visible.ToString()));
            if (!string.IsNullOrWhiteSpace(copyToOutputDirectory)) attributes.Add(ItemAttributes.CopyToOutputDirectory(copyToOutputDirectory));
            return new MsBuildItem(ItemConstants.Content,
                ItemAttributeLists.Create(attributes.ToArray()),
                condition);
        }

        public static MsBuildItem EmbeddedResource(
            string generator,
            string lastGenOutput,
            string customToolNamespace,
            string logicalName,
            string dependentUpon = null,
            string link = null,
            bool? visible = null,
            string copyToOutputDirectory = null,
            string condition = null)
        {
            var attributes = new List<MsBuildItemAttribute>();
            attributes.Add(ItemAttributes.Generator(generator));
            attributes.Add(ItemAttributes.LastGenOutput(lastGenOutput));
            attributes.Add(ItemAttributes.CustomToolNamespace(customToolNamespace));
            attributes.Add(ItemAttributes.LogicalName(logicalName));
            if (!string.IsNullOrWhiteSpace(dependentUpon)) attributes.Add(ItemAttributes.DependentUpon(dependentUpon));
            if (!string.IsNullOrWhiteSpace(link)) attributes.Add(ItemAttributes.Link(link));
            if (visible != null) attributes.Add(ItemAttributes.Visible(visible.ToString()));
            if (!string.IsNullOrWhiteSpace(copyToOutputDirectory)) attributes.Add(ItemAttributes.CopyToOutputDirectory(copyToOutputDirectory));
            return new MsBuildItem(ItemConstants.EmbeddedResource,
                ItemAttributeLists.Create(attributes.ToArray()),
                condition);
        }

        public static MsBuildItem NativeReference(
            string name,
            string hintPath,
            string condition = null)
        {
            var attributes = new List<MsBuildItemAttribute>();
            attributes.Add(ItemAttributes.Name(name));
            attributes.Add(ItemAttributes.HintPath(hintPath));
            return new MsBuildItem(ItemConstants.NativeReference,
                ItemAttributeLists.Create(attributes.ToArray()),
                condition);
        }

        public static MsBuildItem None(
            string generator,
            string lastGenOutput,
            string customToolNamespace,
            string dependentUpon = null,
            string link = null,
            bool? visible = null,
            string copyToOutputDirectory = null,
            string condition = null)
        {
            var attributes = new List<MsBuildItemAttribute>();
            attributes.Add(ItemAttributes.Generator(generator));
            attributes.Add(ItemAttributes.LastGenOutput(lastGenOutput));
            attributes.Add(ItemAttributes.CustomToolNamespace(customToolNamespace));
            if (!string.IsNullOrWhiteSpace(dependentUpon)) attributes.Add(ItemAttributes.DependentUpon(dependentUpon));
            if (!string.IsNullOrWhiteSpace(link)) attributes.Add(ItemAttributes.Link(link));
            if (visible != null) attributes.Add(ItemAttributes.Visible(visible.ToString()));
            if (!string.IsNullOrWhiteSpace(copyToOutputDirectory)) attributes.Add(ItemAttributes.CopyToOutputDirectory(copyToOutputDirectory));
            return new MsBuildItem(ItemConstants.None,
                ItemAttributeLists.Create(attributes.ToArray()),
                condition);
        }

        public static MsBuildItem ProjectReference(
            string name = null,
            string project = null,
            string package = null,
            string condition = null)
        {
            var attributes = new List<MsBuildItemAttribute>();
            if (!string.IsNullOrWhiteSpace(name)) attributes.Add(ItemAttributes.Name(name));
            if (!string.IsNullOrWhiteSpace(project)) attributes.Add(ItemAttributes.Project(project));
            if (!string.IsNullOrWhiteSpace(package)) attributes.Add(ItemAttributes.Package(package));
            return new MsBuildItem(ItemConstants.ProjectReference,
                ItemAttributeLists.Create(attributes.ToArray()),
                condition);
        }

        public static MsBuildItem Reference(
            string hintPath = null,
            string name = null,
            string fusionName = null,
            bool? specificVersion = null,
            string aliases = null,
            bool? @private = null,
            string condition = null)
        {
            var attributes = new List<MsBuildItemAttribute>();
            if (!string.IsNullOrWhiteSpace(hintPath)) attributes.Add(ItemAttributes.HintPath(hintPath));
            if (!string.IsNullOrWhiteSpace(name)) attributes.Add(ItemAttributes.Name(name));
            if (!string.IsNullOrWhiteSpace(fusionName)) attributes.Add(ItemAttributes.FusionName(fusionName));
            if (specificVersion != null) attributes.Add(ItemAttributes.SpecificVersion(specificVersion.ToString()));
            if (!string.IsNullOrWhiteSpace(aliases)) attributes.Add(ItemAttributes.Aliases(aliases));
            if (@private != null) attributes.Add(ItemAttributes.Private(@private.ToString()));
            return new MsBuildItem(ItemConstants.Reference,
                ItemAttributeLists.Create(attributes.ToArray()),
                condition);
        }
    }
}
