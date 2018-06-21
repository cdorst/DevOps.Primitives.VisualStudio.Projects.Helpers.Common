using System.Collections.Generic;
using static System.String;

namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class Items
    {
        public static MsBuildItem COMFileReference(
            in string wrapperTool = default,
            in string condition = default)
        {
            var attributes = new List<MsBuildItemAttribute>();
            if (!IsNullOrWhiteSpace(wrapperTool)) attributes.Add(ItemAttributes.WrapperTool(in wrapperTool));
            return new MsBuildItem(ItemConstants.COMFileReference,
                ItemAttributeLists.Create(attributes.ToArray()),
                in condition);
        }

        public static MsBuildItem Compile(
            in string dependentUpon = default,
            in bool? autoGen = default,
            in string link = default,
            in bool? visible = default,
            in string copyToOutputDirectory = default,
            in string condition = default)
        {
            var attributes = new List<MsBuildItemAttribute>();
            if (!IsNullOrWhiteSpace(dependentUpon)) attributes.Add(ItemAttributes.DependentUpon(in dependentUpon));
            if (autoGen != null) attributes.Add(ItemAttributes.AutoGen(autoGen.ToString()));
            if (!IsNullOrWhiteSpace(link)) attributes.Add(ItemAttributes.Link(in link));
            if (visible != null) attributes.Add(ItemAttributes.Visible(visible.ToString()));
            if (!IsNullOrWhiteSpace(copyToOutputDirectory)) attributes.Add(ItemAttributes.CopyToOutputDirectory(in copyToOutputDirectory));
            return new MsBuildItem(ItemConstants.Compile,
                ItemAttributeLists.Create(attributes.ToArray()),
                in condition);
        }

        public static MsBuildItem COMReference(
            in string name = default,
            in string guid = default,
            in string versionMajor = default,
            in string versionMinor = default,
            in string lcid = default,
            in string wrapperTool = default,
            in bool? isolated = default,
            in string condition = default)
        {
            var attributes = new List<MsBuildItemAttribute>();
            if (!IsNullOrWhiteSpace(name)) attributes.Add(ItemAttributes.Name(in name));
            if (!IsNullOrWhiteSpace(guid)) attributes.Add(ItemAttributes.Guid(in guid));
            if (!IsNullOrWhiteSpace(versionMajor)) attributes.Add(ItemAttributes.VersionMajor(in versionMajor));
            if (!IsNullOrWhiteSpace(versionMinor)) attributes.Add(ItemAttributes.VersionMinor(in versionMinor));
            if (!IsNullOrWhiteSpace(lcid)) attributes.Add(ItemAttributes.LCID(in lcid));
            if (!IsNullOrWhiteSpace(wrapperTool)) attributes.Add(ItemAttributes.WrapperTool(in wrapperTool));
            if (isolated != null) attributes.Add(ItemAttributes.Isolated(isolated.ToString()));
            return new MsBuildItem(ItemConstants.COMReference,
                ItemAttributeLists.Create(attributes.ToArray()),
                in condition);
        }

        public static MsBuildItem Content(
            in string generator,
            in string lastGenOutput,
            in string customToolNamespace,
            in string dependentUpon = default,
            in string link = default,
            in string publishState = default,
            in bool? isAssembly = default,
            in bool? visible = default,
            in string copyToOutputDirectory = default,
            in string condition = default)
        {
            var attributes = new List<MsBuildItemAttribute>
            {
                ItemAttributes.Generator(in generator),
                ItemAttributes.LastGenOutput(in lastGenOutput),
                ItemAttributes.CustomToolNamespace(in customToolNamespace)
            };
            if (!IsNullOrWhiteSpace(dependentUpon)) attributes.Add(ItemAttributes.DependentUpon(in dependentUpon));
            if (!IsNullOrWhiteSpace(link)) attributes.Add(ItemAttributes.Link(in link));
            if (!IsNullOrWhiteSpace(publishState)) attributes.Add(ItemAttributes.PublishState(in publishState));
            if (isAssembly != null) attributes.Add(ItemAttributes.IsAssembly(isAssembly.ToString()));
            if (visible != null) attributes.Add(ItemAttributes.Visible(visible.ToString()));
            if (!IsNullOrWhiteSpace(copyToOutputDirectory)) attributes.Add(ItemAttributes.CopyToOutputDirectory(in copyToOutputDirectory));
            return new MsBuildItem(ItemConstants.Content,
                ItemAttributeLists.Create(attributes.ToArray()),
                in condition);
        }

        public static MsBuildItem EmbeddedResource(
            in string generator,
            in string lastGenOutput,
            in string customToolNamespace,
            in string logicalName,
            in string dependentUpon = default,
            in string link = default,
            in bool? visible = default,
            in string copyToOutputDirectory = default,
            in string condition = default)
        {
            var attributes = new List<MsBuildItemAttribute>
            {
                ItemAttributes.Generator(in generator),
                ItemAttributes.LastGenOutput(in lastGenOutput),
                ItemAttributes.CustomToolNamespace(in customToolNamespace),
                ItemAttributes.LogicalName(in logicalName)
            };
            if (!IsNullOrWhiteSpace(dependentUpon)) attributes.Add(ItemAttributes.DependentUpon(in dependentUpon));
            if (!IsNullOrWhiteSpace(link)) attributes.Add(ItemAttributes.Link(in link));
            if (visible != null) attributes.Add(ItemAttributes.Visible(visible.ToString()));
            if (!IsNullOrWhiteSpace(copyToOutputDirectory)) attributes.Add(ItemAttributes.CopyToOutputDirectory(in copyToOutputDirectory));
            return new MsBuildItem(ItemConstants.EmbeddedResource,
                ItemAttributeLists.Create(attributes.ToArray()),
                in condition);
        }

        public static MsBuildItem NativeReference(
            in string name,
            in string hintPath,
            in string condition = default)
        {
            var attributes = new List<MsBuildItemAttribute>
            {
                ItemAttributes.Name(in name),
                ItemAttributes.HintPath(in hintPath)
            };
            return new MsBuildItem(ItemConstants.NativeReference,
                ItemAttributeLists.Create(attributes.ToArray()),
                in condition);
        }

        public static MsBuildItem None(
            in string generator,
            in string lastGenOutput,
            in string customToolNamespace,
            in string dependentUpon = default,
            in string link = default,
            in bool? visible = default,
            in string copyToOutputDirectory = default,
            in string condition = default)
        {
            var attributes = new List<MsBuildItemAttribute>
            {
                ItemAttributes.Generator(in generator),
                ItemAttributes.LastGenOutput(in lastGenOutput),
                ItemAttributes.CustomToolNamespace(in customToolNamespace)
            };
            if (!IsNullOrWhiteSpace(dependentUpon)) attributes.Add(ItemAttributes.DependentUpon(in dependentUpon));
            if (!IsNullOrWhiteSpace(link)) attributes.Add(ItemAttributes.Link(in link));
            if (visible != null) attributes.Add(ItemAttributes.Visible(visible.ToString()));
            if (!IsNullOrWhiteSpace(copyToOutputDirectory)) attributes.Add(ItemAttributes.CopyToOutputDirectory(in copyToOutputDirectory));
            return new MsBuildItem(ItemConstants.None,
                ItemAttributeLists.Create(attributes.ToArray()),
                in condition);
        }

        public static MsBuildItem ProjectReference(
            in string name = default,
            in string project = default,
            in string package = default,
            in string condition = default)
        {
            var attributes = new List<MsBuildItemAttribute>();
            if (!IsNullOrWhiteSpace(name)) attributes.Add(ItemAttributes.Name(in name));
            if (!IsNullOrWhiteSpace(project)) attributes.Add(ItemAttributes.Project(in project));
            if (!IsNullOrWhiteSpace(package)) attributes.Add(ItemAttributes.Package(in package));
            return new MsBuildItem(ItemConstants.ProjectReference,
                ItemAttributeLists.Create(attributes.ToArray()),
                in condition);
        }

        public static MsBuildItem Reference(
            in string hintPath = default,
            in string name = default,
            in string fusionName = default,
            in bool? specificVersion = default,
            in string aliases = default,
            in bool? @private = default,
            in string condition = default)
        {
            var attributes = new List<MsBuildItemAttribute>();
            if (!IsNullOrWhiteSpace(hintPath)) attributes.Add(ItemAttributes.HintPath(in hintPath));
            if (!IsNullOrWhiteSpace(name)) attributes.Add(ItemAttributes.Name(in name));
            if (!IsNullOrWhiteSpace(fusionName)) attributes.Add(ItemAttributes.FusionName(in fusionName));
            if (specificVersion != null) attributes.Add(ItemAttributes.SpecificVersion(specificVersion.ToString()));
            if (!IsNullOrWhiteSpace(aliases)) attributes.Add(ItemAttributes.Aliases(in aliases));
            if (@private != null) attributes.Add(ItemAttributes.Private(@private.ToString()));
            return new MsBuildItem(ItemConstants.Reference,
                ItemAttributeLists.Create(attributes.ToArray()),
                in condition);
        }
    }
}
