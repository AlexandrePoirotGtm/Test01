using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            String j = "";
            Console.WriteLine("Qu'est ce que tu aimes?");
            j = Console.ReadLine();
            Console.WriteLine("Tu aime " + j);

            Console.WriteLine("Et combien en veux tu?");
            string c = "";
            c = Console.ReadLine();
            Console.WriteLine("Tu veux " + c + " " + j);
        }
    }
}
