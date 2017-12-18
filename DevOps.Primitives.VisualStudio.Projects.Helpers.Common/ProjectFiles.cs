namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class ProjectFiles
    {
        public static MsBuildProjectFile Create(ProjectType projectType, MsBuildPropertyGroupList propertyGroupList, MsBuildItemGroupList itemGroupList = null)
            => new MsBuildProjectFile(
                projectType,
                ItemPropertyConditionSections.Create(propertyGroupList, itemGroupList),
                targetList: null);
    }
}
