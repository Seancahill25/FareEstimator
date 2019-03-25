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
            int time = fare.Travel();

            Console.WriteLine("Enter travel distance. ");
            int Distance = fare.Travel();

            Console.WriteLine("Enter cost per minute. " + cars + " times");
            double[] CPMinute = fare.Cost(cars);

            Console.WriteLine("Enter cost per mile. " + cars + " times");
            double[] CPMile = fare.Cost(cars);

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
        
        public int Travel()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public double[] Cost(int cars)
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
