using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleFamily
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Family family =
                new Family(
                    new object[] { new Dad(), new Mom(), new Boy(), new Dog() });

            family.WinterBegins();
            family.SummerComes();
            Console.ReadLine();
        }
    }
}
