using System;

namespace BBIT_Task_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n\n ========== Unsorted random 2d array ==========");

            Array array = new Array(-100, 100);
            array.Render(1, 5);

            var coords = array.GetMinCoords();
            Console.WriteLine($"\n\n Min value is {array.GetValue(coords)} at {coords}");

            coords = array.GetMaxCoords();
            Console.WriteLine($" Max value is {array.GetValue(coords)} at {coords}");

            Console.WriteLine($"\n\n ========== Sorted random 2d array ==========");

            array.Sort();
            array.Render(1, 33);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
