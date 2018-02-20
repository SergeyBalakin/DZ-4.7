using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4._7
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine();
            Console.WriteLine("    1 - е    Авто");
            Console.WriteLine();
            Console.Write("     Название авто               ");
            string a = Console.ReadLine();
            Console.Write("     Максимальна скорость        ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("     Расход литров на 100 км     ");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    2 - е    Авто");
            Console.WriteLine();
            Console.Write("     Название авто               ");
            string b = Console.ReadLine();
            Console.Write("     Максимальна скорость        ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("     Расход литров на 100 км     ");
            int b2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    3 - е    Авто");
            Console.WriteLine();
            Console.Write("     Название авто               ");
            string c = Console.ReadLine();
            Console.Write("     Максимальна скорость        ");
            int c1 = int.Parse(Console.ReadLine());
            Console.Write("     Расход литров на 100 км     ");
            int c2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("     Сравнение по максимальной скорости");
            Console.WriteLine();
            Console.WriteLine($"     {a,10}     {b,10}     {c,10}");
            Console.WriteLine($"     {a1,10}    {b1,10}    {c1,10}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("     Сравнение по расходу литров на 100 км");
            Console.WriteLine();
            Console.WriteLine($"     {a,10}     {b,10}     {c,10}");
            Console.WriteLine($"     {a2,10}    {b2,10}    {c2,10}");

            Console.ReadKey();


        }
    }
}
