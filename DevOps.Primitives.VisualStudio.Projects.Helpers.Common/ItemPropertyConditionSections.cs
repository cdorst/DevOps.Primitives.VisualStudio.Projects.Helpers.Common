namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class ItemPropertyConditionSections
    {
        public static MsBuildConditionalContructItemGroupPropertyGroupSection Create(MsBuildPropertyGroupList propertyGroupList, MsBuildItemGroupList itemGroupList = null, MsBuildConditionalConstructList conditionalConstructList = null)
            => new MsBuildConditionalContructItemGroupPropertyGroupSection(propertyGroupList, itemGroupList, conditionalConstructList);
    }
}
