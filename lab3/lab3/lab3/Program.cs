using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine("Liczba " +a +" jest najwieksza");
            else if (b>c)
                Console.WriteLine("Liczba " + b + " jest najwieksza");
            else
                Console.WriteLine("Liczba " + c + " jest najwieksza");
        }
    }
}
