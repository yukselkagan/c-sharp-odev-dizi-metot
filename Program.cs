using System;

namespace c_sharp_odev_dizi_metot
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 12, 20, 35, 5, 2, 6, 10 };


            Console.WriteLine("Without change:");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            Array.Sort(numbers);
            Console.WriteLine("Array Sort:");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }



            Array.Clear(numbers, 2, 2);
            Console.WriteLine("Array Clean:");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }




            Array.Reverse(numbers);
            Console.WriteLine("Array Reverse:");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("Array index of:");
            Console.WriteLine( Array.IndexOf(numbers, 20) );


            Array.Resize<int>(ref numbers, 15);
            Console.WriteLine("Array Resize:");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }












        }
    }
}
