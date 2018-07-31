using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Test01
{
    class Program
    {

        static void Main(string[] args)
        {
        Accueil:
           //DateTime date = DateTime.Now;
           Console.WriteLine("Bienvenue!!!\nNous somme le : "+ DateTime.Now +"\n--1 Addition\n--2 Chose que tu aimes\n--3 Liste de tes choses favorites");
            string option = "d";
            option = Console.ReadLine();
            if (option == "1")
            {
                Console.WriteLine("Quel deux chiffres veut tu additionner? \n");
                int calA, calB;
                calA = int.Parse(Console.ReadLine());
                calB = int.Parse(Console.ReadLine());
                Console.WriteLine(calA + " + " + calB + " = " + additionBis(calA, calB));
            }
            else if(option == "2")
            { 
                String j = "";
                Console.WriteLine("Qu'est ce que tu aimes?");
                j = Console.ReadLine();
                Console.WriteLine("Tu aime " + j);

                Console.WriteLine("Et combien en veux tu?");
                string c = "";
                c = Console.ReadLine();
                Console.WriteLine("Tu veux " + c + " " + j + ".\n");
                int d = int.Parse(c);
                int e = 0;
                while (e != d)
                    {
                    Console.WriteLine("Appuie sur n'importe quelle touche pour augmenter le nombre de " + j + "\n");
                    e++;
                    Console.ReadKey();
                    Console.WriteLine(e + " " + j + "\n");
                    };

                Console.WriteLine("Veux tu vendre ton âme pour " + c + " " + j + " ? \nY ou N");
                c = Console.ReadLine();
                if (c == "Y" | c == "y")
                    {
                     Console.WriteLine("Merci pour ton âme...dors bien pour ta dernière nuit");
                    }
                else if (c == "N" | c == "n")
                    {
                     Console.WriteLine("Tant pis, une prochaine fois peut-être...");
                    }
                else
                    {
                     Console.WriteLine("Tu n'est même pas capable de lire correctement, ton âme n'aurais aucun goût");
                    }
            }
            else if(option == "3")
            {
                Console.WriteLine("Combien de choses préféres veut tu rentrer?");
                int nb = 0,nbr = 0;
                nbr = int.Parse(Console.ReadLine());
                string[] Choses = new string[nbr];
                while (nb != nbr)
                {
                    Console.WriteLine("Quel est ta chose préférer?");
                    Choses[nb]=Console.ReadLine();
                    nb++;
                };
                nb = 0;
                while(nb != nbr)
                {
                    Console.WriteLine("Ta chose préférer est : " + Choses[nb]);
                    nb++;
                };
            }
            else if(option == "4")
            {
                ArrayList prenoms = new ArrayList();
               
                  Console.WriteLine("Quel est ta chose préférer?");
                prenoms.Add(Console.ReadLine());
                    Console.WriteLine("Ta chose préférer est : " + prenoms[0]);
            
            }
            else
            {
                Console.WriteLine("L'option n'est pas encore intégrée\nVeux tu retourner à l'accueil? Y ou N");
                string c = "";
                c = Console.ReadLine();
                if (c == "Y" | c == "y")
                {
                    goto Accueil;
                }
            }
            int additionBis(int a, int b)
            {
                int cc = 0;
                int ab = 0;
                int bb = 0;
                ab = a;
                bb = b;
                cc = ab + bb;
                return (cc);
            }
        }
    }
}
