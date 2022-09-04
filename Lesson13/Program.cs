using System;

class Program
{
    static void Main(string[] args) {
        Byers tom = new Byers("Tom", 123456789);
        Sellers bob = new Sellers("Bob", 111222333444);
        Products laptop = new Products("laptop",44556677, "good laptop");
        Products frenchPress = new Products("frenchPress", 44556678, "good kettle");
        GoodMoves computer = new GoodMoves();
        computer.setPrice(bob, laptop, 1000000.01);
        computer.addNote(tom, laptop, 1200000, 10);
        GoodMoves kettle = new GoodMoves();
        kettle.setPrice(bob, frenchPress, 10.50);
        kettle.addNote(tom, frenchPress, 120, 80);
    }

    interface IStoreInterface
    {        
        void addProduct(string product);
        void removeProduct(string product);
        void addByer(string byer);
        void removeByer(string byer);
        void addSeller(string seller);
        void removeSeller(string seller);
        void setPrice(Sellers seller, Products good, double price);
        void addNote(Byers byer, Products good, double price, long quality);
    }

    class GoodMoves: IStoreInterface
    {
        public void addProduct(string product)
        {
            Console.WriteLine("Product added to DB");
        }

        public void removeProduct(string product)
        {
            Console.WriteLine("Product removed from DB");
        }

        public void addByer(string product)
        {
            Console.WriteLine("Byer added to DB");
        }

        public void removeByer(string product)
        {
            Console.WriteLine("Byer removed from DB");
        }
        public void addSeller(string product)
        {
            Console.WriteLine("Seller added to DB");
        }

        public void removeSeller(string product)
        {
            Console.WriteLine("Seller removed from DB");
        }

        public void setPrice(Sellers seller, Products good, double price)
        {
            Console.WriteLine("Seller " + seller.Name + " sell " + good.Name + " for the " + price);
        }
        public void addNote(Byers byer, Products good, double price, long quality)
        {
            Console.WriteLine("Byer " + byer.Name + " buy " + good.Name + " in quality " + quality + " for the " + price + " piece");
        }

    }

    class Products
    {
        public string Name { get; set; }
        int Id { get; set; }
        string Description { get; set; }

        public Products(string name, int id, string description)
        {
            Name = name;
            Id = id;
            Description = description;
        }
    }

    class Byers
    {
        public string Name { get; set; }
        int Telephone { get; set; }

        public Byers(string name, int telephone)
        {
            Name = name;           
            Telephone = telephone;
        }
    }

    class Sellers
    {
        public string Name { get; set; }
        long  Inn { get; set; }
        
        public Sellers(string name, long inn)
        {
            Name = name;
            Inn = inn;
        }
    }
    interface IProducrProperty
    {
        public string getColor();
        public string getMatherial();
    }

     struct ProductsProp : IProducrProperty
    {
        Products product;
        string colour;
        string matherial;

        public string getColor()
        { 
            return $"product {product} have {colour}";
        }

        public string getMatherial()
        {
            return $"product {product} made from {matherial}";
        }
    }
}
//checked
