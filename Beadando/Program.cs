using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    class Program
    {
        static void Main(string[] args)
        {
            Input inputData = new Input();
            ReadInput reader = new ReadInput();
            string error = string.Empty;
            if (reader.ReadTxt("E0.in", ref error, ref inputData))
            {
                Console.WriteLine(inputData.ToString());
                FuelConsciousness fC = new FuelConsciousness();

                int sum = fC.CalculateMinCost(inputData);
                //Write minimal cost of trip (red - error; green - valid value) 
                Console.ForegroundColor = ConsoleColor.Red;
                if (sum >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine("Sum: " + sum);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(error);
            }
            Console.ReadKey();
        }
    }
}
