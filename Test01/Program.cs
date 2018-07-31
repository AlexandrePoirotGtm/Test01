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
            int d = int.Parse(c);
            int e = 0;
            while(e != d)
            {
                e++;
                Console.WriteLine(e + " " + j);
                Console.ReadLine();
            };

            Console.WriteLine("Veux tu vendre ton âme pour " + c + " " + j +" ? \nY ou N");
            c = Console.ReadLine();
            if(c == "Y" | c == "y")
            {
                Console.WriteLine("Merci pour ton âme...dors bien pour ta dernière nuit");
            }
            else if(c == "N" | c == "n")
            {
                Console.WriteLine("Tant pis, une prochaine fois peut-être...");
            }
            else
            {
                Console.WriteLine("Tu n'est même pas capable de lire correctement, ton âme n'aurais aucun goût");
            }
        }
    }
}
