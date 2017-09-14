using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car();
            firstCar.Brand = "BMW";
            firstCar.Model = "M7";
            firstCar.YearOfUse = 2017;

            Console.WriteLine("First car brand: "+ firstCar.Brand + "; model: " + firstCar.Model + "; year of manufacture: " + firstCar.YearOfUse);
            firstCar.startEngine(5);

            FighterPlane firstFightPlane = new FighterPlane();
            firstFightPlane.Brand = "Boing";
            firstFightPlane.Model = "Harier";
            firstFightPlane.YearOfUse = 2016;
            Console.WriteLine("First Fight Plane brand: " + firstFightPlane.Brand + "; model: " + firstFightPlane.Model + "; year of manufacture: " + firstFightPlane.YearOfUse);
            firstFightPlane.startEngine(5);

            Console.ReadKey();
        }
    }
}
