using System.Collections.Generic;

namespace WindowsDatabase.Classes.Database.Table
{
    public class UnitCollectionOrder
    {
        private Product _product;
        private int _count;

        public UnitCollectionOrder(Product product, int count)
        {
            _product = product;
            _count = count;
        }
        public Product Product => _product;
        public int Count => _count;
    }
}
