using CommunityToolkit.Mvvm.ComponentModel;

namespace Grocery.Core.Models
{
    public partial class Product : Model
    {
        [ObservableProperty]
        private int stock;

        [ObservableProperty]
        private decimal price;  // prijs voor product
        public DateOnly ShelfLife { get; set; }
        public Product(int id, string name, int stock) : this(id, name, stock,default, 0m) { }
        public Product(int id, string name, int stock, DateOnly shelfLife) : this(id, name, stock, shelfLife, 0m) { }

        public Product(int id, string name, int stock, DateOnly shelfLife, decimal price) : base(id, name) 
        {
            Stock = stock;
            ShelfLife = shelfLife;
            Price = price;      
        }
        public override string? ToString()
        {
            return $"{Name} - {Stock} op voorraad - {Price}";
        }
    }
}
