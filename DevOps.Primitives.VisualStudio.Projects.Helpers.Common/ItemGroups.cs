namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class ItemGroups
    {
        public static MsBuildItemGroup Create(params MsBuildItem[] items)
            => new MsBuildItemGroup(ItemLists.Create(items), condition: default(MsBuildCondition));
    }
}
