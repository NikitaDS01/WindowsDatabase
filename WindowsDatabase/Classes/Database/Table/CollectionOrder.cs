using System.Collections.Generic;

namespace WindowsDatabase.Classes.Database.Table
{
    public class CollectionOrder
    {
        private List<UnitCollectionOrder> _collectionOrders;

        public CollectionOrder(List<UnitCollectionOrder> collectionOrders)
        {
            _collectionOrders = collectionOrders;
        }
        public IReadOnlyList<UnitCollectionOrder> CollectionOrders =>
            _collectionOrders;
    }
}
