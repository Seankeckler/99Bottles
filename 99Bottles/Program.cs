using System;

namespace _99Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int onWall = 99;
            int takeOffWall = 98;
            while (onWall > 2)
            {
                Console.WriteLine("{0} bottles of beer on the wall, \r\n{0} bottles of beer, \r\ntake one down, \r\npass it around, \r\n{1} bottles of beer on the wall.", onWall, takeOffWall);
                Console.WriteLine("");
                Console.ReadKey();
                onWall = onWall - 1;
                takeOffWall = takeOffWall - 1;
                Console.Clear();
            }
            while (onWall > 1)
            {
                Console.WriteLine("{0} bottles of beer on the wall, \r\n{0} bottles of beer,  \r\ntake one down,  \r\npass it around,  \r\n{1} bottle of beer on the wall.", onWall, takeOffWall);
                Console.WriteLine("");
                Console.ReadKey();
                onWall = onWall - 1;
                takeOffWall = takeOffWall - 1;
                Console.Clear();
            }
            Console.WriteLine("{0} bottle of beer on the wall,  \r\n{0} bottle of beer,  \r\ntake one down,  \r\npass it around,  \r\n{1} bottles of beer on the wall.", onWall, takeOffWall);
            Console.WriteLine("");
        }
    }
}
