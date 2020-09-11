using System;

namespace DND_Age_Converter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("selecta race");
            Console.WriteLine("1:Dwarf   2:Elf   3:Halfling   4:Dragonborn");
            Console.WriteLine("5:Gnome   6:Half-elf   7:Half-Orc   8:Tiefling");
            int Race = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Input Age");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (Race)
            {
                case 1:
                    Console.WriteLine(Age * 0.2285714285714286);
                    break;

                case 2:
                    Console.WriteLine(Age * 0.1066666666666667);
                    break;

                case 3:
                    Console.WriteLine(Age * 0.5333333333333333);
                    break;

                case 4:
                    Console.WriteLine(Age * 1.23076923077);
                    break;

                case 5:
                    Console.WriteLine(Age * 0.16);
                    break;

                case 6:
                    Console.WriteLine(Age * 0.4444444444444444);
                    break;

                case 7:
                    Console.WriteLine(Age * 1.066666666666667);
                    break;

                case 8:
                    Console.WriteLine("Tieflings mature at the same rate but stay younger longer.");
                    Console.WriteLine(Age * 0.5333333333333333);
                    break;
            }

            Console.WriteLine("Approximate human years");
            Console.WriteLine("press enter to exit");
            Console.ReadLine();
         }
    }
}
