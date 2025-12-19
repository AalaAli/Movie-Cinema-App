using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Seats
{
    public class SeatFlyweight
    {
        public string TypeName { get; }
        public string Color { get; }
        public double Price { get; }
        public double Width { get; }
        public string Description { get; }

        public SeatFlyweight(string typeName, string color, double price, double width, string description)
        {
            TypeName = typeName;
            Color = color;
            Price = price;
            Width = width;
            Description = description;
        }

        public void ShowFlyweightInfo()
        {
            Console.WriteLine(
                $"Type: {TypeName}, Color: {Color}, Price: {Price}, Width: {Width}, Description: {Description}");
        }
    }
}
