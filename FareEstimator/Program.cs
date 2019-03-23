using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FareEstimator
{
    class Program
    {
        public static void Main(string[] args)
        {
            var fare = new Fares();

            int cars =  fare.Cars();

            Console.WriteLine("Enter travel time. ");
            int time = fare.TravelTime();

            Console.WriteLine("Enter travel distance. ");
            int Distance = fare.TravelDistance();

            Console.WriteLine("Enter cost per minute. " + cars + " times");
            double[] CPMinute = fare.CostPerMinute(cars);

            Console.WriteLine("Enter cost per mile. " + cars + " times");
            double[] CPMile = fare.CostPerMile(cars);

            for (var i = 0; i < CPMile.Length; i++)
            {
                double fares = CPMinute[i] * time + CPMile[i] * Distance;
                Console.WriteLine("Fare = $" + fares);
            }
                                       
        }      
    }

    public class Fares
    {
        
        public int Cars()
        {
            Random car = new Random();
            int total = car.Next(4,10);
            return total;
        }
        
        public int TravelTime()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public int TravelDistance()
        {         
            return Convert.ToInt32(Console.ReadLine());
        }

        public double[] CostPerMinute(int cars)
        {
            double[] costs = new double[cars];

            for (var i = 0; i < costs.Length; i++)
            {             
                costs[i] = Convert.ToDouble(Console.ReadLine());
            }
            return costs;
        }

        public double[] CostPerMile(int cars)
        {
            double[] costs = new double[cars];

            for (var i = 0; i < costs.Length; i++)
            {
                costs[i] = Convert.ToDouble(Console.ReadLine());
            }
            return costs;
        }
    }
}
