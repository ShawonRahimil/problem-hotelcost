using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double single = 45.50;
            double duble = 99.99;
            double Luxury = 165.25;
            double  penthouse=1095.50;
            Console.WriteLine("Room types:");
            Console.WriteLine($"1.Single {single} BDT per night");
            Console.WriteLine($"2.Double {duble} BDT per night");
            Console.WriteLine($"3.Luxury {Luxury} BDT per night");
            Console.WriteLine($"4.Penthouse {penthouse} BDT per night");
            Console.WriteLine();
            Console.Write($"Please Select a room type 1.single, 2.double, 3.Luxury or 4.penthouse:");
            int roomtype = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter the number of night:");
            int numberofnight=int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (roomtype==1)
            {
                
                Console.WriteLine("Your room type is single");
                 double totalcost=single*numberofnight;
                Console.WriteLine($"Thank You , the total cost for staying in the single room for {numberofnight} night:{totalcost} BDT");
            }
            if (roomtype == 2)
            {
                Console.WriteLine("Your room type is double");
                double totalcost = duble * numberofnight;
                Console.WriteLine($"Thank You , the total cost for staying in the double room for {numberofnight} night:{totalcost} BDT");
            }
            if (roomtype == 3)
            {
                Console.WriteLine("Your room type is Luxury");
                double totalcost = Luxury * numberofnight;
                Console.WriteLine($"Thank You , the total cost for staying in the Luxury room for {numberofnight} night:{totalcost} BDT");
            }
            if (roomtype == 4)
            {
                Console.WriteLine("Your room type is Luxury");
                double totalcost = penthouse * numberofnight;
                Console.WriteLine($"Thank You , the total cost for staying in the penthouse room for {numberofnight} night:{totalcost} BDT");
            }

            Console.ReadKey();


        }
    }
}
