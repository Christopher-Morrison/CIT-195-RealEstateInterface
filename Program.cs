using System;
namespace RealEstateInterface
{
    class Program
    {
        interface IRealEstate
        {
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public int PostalCode { get; set; }
            public double LotSize { get; set; }
            public double Price { get; set; }

            public string SqftPrice();
            public string FullAddress();
        }
        class Listing : IRealEstate
        {
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public int PostalCode { get; set; }
            public double LotSize { get; set; }
            public double Price { get; set; }
            public Listing()
            {
                Address = string.Empty;
                City = string.Empty;
                State = string.Empty;
                PostalCode = 0;
                LotSize = 0;
                Price = 0;
            }
            public Listing(string address, string city, string state, int postalCode, double lotSize, double price)
            {
                Address = address;
                City = city;
                State = state;
                PostalCode = postalCode;
                LotSize = lotSize;
                Price = price;
            }

            public string SqftPrice()
            {
                double quotient = Price / LotSize;
                return $"${Math.Ceiling(quotient)}/sqft";
            }
            public string FullAddress()
            {
                return $"{Address}, {City}, {State} {PostalCode}";
            }

        }
        static void Main(string[] args)
        {
            Listing floridaHouse = new Listing("48 Logo Ct", "Fort Myers","FL",33912,1392,33900);
            Console.WriteLine("Here is your listing:");
            Console.WriteLine(floridaHouse.FullAddress());
            Console.WriteLine(floridaHouse.SqftPrice());
        }
    }
}