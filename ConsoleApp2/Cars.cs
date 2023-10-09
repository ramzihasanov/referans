using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public  class Cars
    {
         public  string Brand;
        public  string Model;
        public  float CurrentFuel;
        public  float FuelFor1km;
        public float  Millage;

           public void  Drive()
        {
            
             float wontDrive;
            float b = CurrentFuel / FuelFor1km;
            bool a = float.TryParse(Console.ReadLine(), out wontDrive);
            if (a)
            {
                if (b >= wontDrive)
                {
                    Millage += wontDrive;
                    CurrentFuel = CurrentFuel - (wontDrive * FuelFor1km);
                    Console.WriteLine( "millage : " + Millage + " " + "currentfuel: " + CurrentFuel);
                }
                else  Console.WriteLine("error"); ;
            }
            else  Console.WriteLine("error"); ;
        }
    }
     

}
