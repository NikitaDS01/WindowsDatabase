using System.Drawing;

namespace WindowsDatabase.Classes.Database.Table
{
    public class Product
    {
        public const string PATH = @"Resource\Image\";

        private string _id;
        private string _name;
        private UnitChange _unitChange;
        private float _price;
        private int _maxDiscount;
        private string _manufacturer;
        private string _supplier;
        private string _category;
        private int _currentDiscount;
        private int _countStorage;
        private string _description;
        private string _pathImage;

        public Product(string id, string name, UnitChange unitChange, float price, int maxDiscount, string manufacturer, string supplier, string category, int currentDiscount, int countStorage, string description, string pathImage)
        {
            _id = id;
            _name = name;
            _unitChange = unitChange;
            _price = price;
            _maxDiscount = maxDiscount;
            _manufacturer = manufacturer;
            _supplier = supplier;
            _category = category;
            _currentDiscount = currentDiscount;
            _countStorage = countStorage;
            _description = description;
            _pathImage = pathImage;
        }
    
        public string Id => _id;
        public string Name => _name;
        public UnitChange UnitChange => _unitChange;
        public float Price => _price;
        public int MaxDiscount => _maxDiscount;
        public string Manufacturer => _manufacturer;
        public string Supplier => _supplier;
        public string Category => _category;
        public int CurrentDiscount => _currentDiscount;
        public int CountStorage => _countStorage;
        public string Description => _description;
        public Image Image => _pathImage==null ? null : Image.FromFile(PATH + _pathImage);
        public string PathImage => _pathImage;
    }
}
