using System.Net.Http.Headers;
using System.Net.WebSockets;

namespace basicInterfaceInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intefaces");
            Console.WriteLine("Intefaces share many things incomon with abstract base classes");
            Console.WriteLine("Whenever you need to work with two fundamentally different classes , but at some point you need to treat them the same way , then you might want to choose an interface");
            Console.WriteLine();
            Console.WriteLine("Implementing multiple interfaces");
            Console.WriteLine("You can implement more than one inteface on a class ");
            Console.WriteLine("Thie means, class has to satislfy the contract or rather must implement the members, the properties and methods inside of the interface in order to implement that given interface");
            Console.WriteLine("You should keep your interfaces segregated into very small cohesive focused ");
            Console.WriteLine("Segregate them, keep them separate, dont force an object to implement methods that it does not need");





            var appointment = new Appointment()
            {
                Name = "Bob",
                StartDateTime = DateTime.Now.AddHours(1),
                EndDateTime= DateTime.Now.AddHours(2),
                Price = 25
            };

            var book = new Book()
            {
                Title = "How to implement Interfaces",
                Price = 50,
                TaxRate =0.12,
                ShippingRate =5,

            };

            var snack = new Snack()
            {
                Price = 2d
            };


            var tshirt = new TShirt()
            {
                Size = "2X",
                Price = 25,
                TaxRate = 0.25,
                ShippingRate = 2
            };


            var items = new List<IPurchasable>();
            items.Add(appointment);
            items.Add(book);
            items.Add(snack);
            items.Add(tshirt);


            var taxableItems = new List<ITaxable>();
            foreach(var item in items)
            {
                if (item is ITaxable)
                {
                    taxableItems.Add(item as ITaxable);
                }
            }

            var taxAmount = CalculateTax(taxableItems);

            Console.WriteLine($"Total tax amouint : {taxAmount}");

            var shippableItems = new List<IShippable>();
            foreach(var item in items)
            {
                if(item is IShippable)
                {
                    shippableItems.Add(item as IShippable);
                }
            }
            var shippingAmount = CalculateShipping(shippableItems);

            Console.WriteLine($"Total ship amouint : {shippingAmount}");

            var total = CompleteTransaction(items);

            var grandTotal = shippingAmount + taxAmount + total;
            Console.WriteLine("==========");
            Console.WriteLine($"Grand total {grandTotal}");

            Console.ReadLine();
        }

        static double CalculateTax(List<ITaxable> items)
        {
            double tax = 0;
            foreach (var item in items)
            {
                tax += item.Tax();
            }
            return tax;
        }

        
        static double CalculateShipping (List<IShippable> items)
        {
            double shipping = 0;

            foreach (var item in items)
            {
                shipping += item.Ship();
            }


            return shipping;
        }

        static double CompleteTransaction(List<IPurchasable>items)
        {

            var total = 0D;

            /*foreach (var item for items)
            {

            }
            */

            items.ForEach(p => p.Purchase());
            items.ForEach(p => total += p.Price);
            return total;
        }
    }

    public class Appointment :IPurchasable
    {
        public string Name { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }
        public double Price { get; set; }

        public void Purchase()
        {
            Console.WriteLine($"Payment for {Name} apointment from {StartDateTime} to {EndDateTime} for {Price.ToString("C0")} . ");

        }
    }

    public class Book :IPurchasable, ITaxable, IShippable
    {
        public string Title { get; set;  }
        public double Price { get; set; }
        public double TaxRate { get ; set; }
        public double ShippingRate { get ; set ; }

        public void Purchase()
        {
            Console.WriteLine($"Purchasing {Title} for {Price.ToString("C0")}. ");
        }

        public double Ship()
        {
            
            Console.WriteLine($"      ShippingRate: {ShippingRate.ToString("C0")}");
            return ShippingRate;
        }

        public double Tax()
        {
            var tax = Price * TaxRate; 
            Console.WriteLine($"       TaxRate: {TaxRate} = {tax}");
            return tax;
        }
    }

    public class TShirt : IPurchasable, ITaxable,IShippable
    {
        public string Size { get; set; }
        public double Price { get; set; }
        public double TaxRate { get; set; }
        public double ShippingRate { get ; set ; }

        public void Purchase()
        {
            Console.WriteLine($"Purchasing TShirt {Size} for {Price.ToString("C0")} . ");
        }

        public double Ship()
        {
            Console.WriteLine($"      ShippingRate: {ShippingRate.ToString("C0")}");
            return ShippingRate;
        }

        public double Tax()
        {
            var tax = Price * TaxRate;
            Console.WriteLine($"       TaxRate: {TaxRate} = {tax}");
            return tax;
        }
    }

    public class Snack : IPurchasable
    {
        public double Price { get; set; }


        public void Purchase()
        {
            Console.WriteLine($"Purchasing a snack for {Price.ToString("C0")} .");
        }
    }

    interface IPurchasable
    {
        double Price { get; set; }

        void Purchase();
    }

    interface IShippable
    {
        double ShippingRate { get; set; }
        double Ship();
    }

    interface ITaxable
    {
        double TaxRate { get; set; }
        double Tax();
    }
}


// https://www.youtube.com/watch?v=cL8j76B7fYQ&list=PLqT8wAi-pOx62b1ITQTnf7fqbzKrNqz7O&index=16