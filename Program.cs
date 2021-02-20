using System;

namespace Sales_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new Product();
            Product p3 = new Product();

            Sale sale1 = new Sale();
            Sale sale2 = new Sale();
            Sale sale3 = new Sale();

            Seller seller1 = new Seller();
            Seller seller2 = new Seller();
            Seller seller3 = new Seller();

            p1.NameProduct = "Milk";
            p1.Price = 2800;

            p2.NameProduct = "Chocolate";
            p2.Price = 5500;

            p3.NameProduct = "Cookies";
            p3.Price = 2000;

            seller1.Name = "Antonio";
            seller1.Age = 24;

            seller2.Name = "Maria";
            seller2.Age = 21;

            seller3.Name = "Rodrigo";
            seller3.Age = 38;

            sale1.Sales = (p1.Price + p2.Price); //2800 + 5500
            sale1.Comments = ("It sold " + p1.NameProduct + " and " + p2.NameProduct + " for " + sale1.Sales);

            sale2.Sales = (p2.Price + p3.Price + p1.Price); //5500 + 2800 + 2000
            sale1.Comments = ("It sold " + p2.NameProduct + ", " + p3.NameProduct + " and " + p1.NameProduct + " for " + sale2.Sales);

            sale3.Sales = (p3.Price); //2000
            sale1.Comments = ("It sold " + p3.NameProduct + " for " + sale3.Sales);

            float SalesTotal = sale1.Sales + sale2.Sales + sale3.Sales;

            Console.WriteLine("The total sales is: " + SalesTotal);
        }
    }
}
