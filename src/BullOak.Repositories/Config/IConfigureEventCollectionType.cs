namespace BullOak.Repositories
{
    using StateTypeToCollectionTypeSelector = System.Func<System.Type, System.Func<System.Collections.Generic.ICollection<ItemWithType>>>;

    public interface IConfigureEventCollectionType : IConfigureBullOak
    {
        IConfigureStateFactory WithEventCollectionSelector(StateTypeToCollectionTypeSelector selectorOfCollectionTypeFromStateType);
    }
}
