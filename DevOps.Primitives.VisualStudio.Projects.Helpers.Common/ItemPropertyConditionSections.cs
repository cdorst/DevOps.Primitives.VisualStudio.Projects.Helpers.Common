namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class ItemPropertyConditionSections
    {
        public static MsBuildConditionalContructItemGroupPropertyGroupSection Create(
            in MsBuildPropertyGroupList propertyGroupList,
            in MsBuildItemGroupList itemGroupList = default,
            in MsBuildConditionalConstructList conditionalConstructList = default)
            => new MsBuildConditionalContructItemGroupPropertyGroupSection(
                in propertyGroupList,
                in itemGroupList,
                in conditionalConstructList);
    }
}
