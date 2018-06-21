namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class ProjectFiles
    {
        public static MsBuildProjectFile Create(
            in ProjectType projectType,
            in MsBuildPropertyGroupList propertyGroupList,
            in MsBuildItemGroupList itemGroupList = default)
            => new MsBuildProjectFile(
                in projectType,
                ItemPropertyConditionSections.Create(in propertyGroupList, in itemGroupList),
                targetList: default);
    }
}
