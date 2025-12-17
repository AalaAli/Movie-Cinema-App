using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Seats
{

    public class SeatFlyweightFactory
    {
        private readonly Dictionary<string, SeatFlyweight> flyweights = new Dictionary<string, SeatFlyweight>();

        public SeatFlyweight GetSeatType(string typeName)
        {
            if (!flyweights.ContainsKey(typeName))
            {
                // قيم افتراضية – يمكن لاحقًا جلبها من DB
                SeatFlyweight flyweight;
                if (typeName == "VIP")
                {
                    flyweight = new SeatFlyweight("VIP", "Red", 50.0, 0.8, "VIP Seat");
                }
                else if (typeName == "Premium")
                {
                    flyweight = new SeatFlyweight("Premium", "Blue", 40.0, 0.75, "Premium Seat");
                }
                else if (typeName == "Premium Seat")
                {
                    flyweight = new SeatFlyweight("Standard", "Gray", 25.0, 0.7, "Standard Seat");
                }
                else
                {
                    flyweight = new SeatFlyweight("Standard", "Gray", 25.0, 0.7, "Standard Seat");
                }
               
                flyweights[typeName] = flyweight;
            }

            return flyweights[typeName];
        }
    }
}
