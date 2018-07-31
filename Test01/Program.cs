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
            Console.WriteLine("Bienvenue!!!\nNous somme le : " + DateTime.Now + "\n--1 Addition\n--2 Chose que tu aimes\n--3 Liste de tes choses favorites\n--4 list\n--5 présente toi\n--6 Calcule de le prix TTC");
            string option = "d";
            option = Console.ReadLine();
            if (option == "1")
            {
                Console.WriteLine("Quel deux chiffres veut tu additionner? \n");
                int calA, calB;
                calA = int.Parse(Console.ReadLine());
                calB = int.Parse(Console.ReadLine());
                Console.WriteLine(calA + " + " + calB + " = " + AdditionBis(calA, calB));
            }
            else if (option == "2")
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
            else if (option == "3")
            {
                Console.WriteLine("Combien de choses préféres veut tu rentrer?");
                int nb = 0, nbr = 0;
                nbr = int.Parse(Console.ReadLine());
                string[] Choses = new string[nbr];
                while (nb != nbr)
                {
                    Console.WriteLine("Quel est ta chose préférer?");
                    Choses[nb] = Console.ReadLine();
                    nb++;
                };
                nb = 0;
                while (nb != nbr)
                {
                    Console.WriteLine("Ta chose préférer est : " + Choses[nb]);
                    nb++;
                };
            }
            else if (option == "4")
            {
                //ArrayList prenoms = new ArrayList();
                List<string> prenoms = new List<string>();
                Console.WriteLine("Quel son tes prenoms préférés?");
                int c = 0;
                Console.WriteLine("\nRentre ton nom préféré:");
                prenoms.Add(Console.ReadLine());
                while (c == 0)
                {
                    Console.WriteLine("\nRentre ton nom préféré:");
                    prenoms.Add(Console.ReadLine());
                    Console.WriteLine("\nVoulez vous rentrez un autre nom? Y ou N?");
                    string cc = Console.ReadLine();
                    if (cc == "Y" | cc == "y")
                    { }
                    else
                        c++;
                }
                Console.WriteLine("\nTon 2eme nom préférer est : " + prenoms[1]);
            }
            else if (option == "5")
            {
                List<string> Personne = new List<string>();
                Personne.Add(PoserQuestion("Quel est ton prenom?"));
                Personne.Add(PoserQuestion("Quel est ton nom?"));
                Personne.Add(PoserQuestion("Quel est ton âge?"));

                /*Console.WriteLine("Quel est ton prenom?");
                Personne.Add(Console.ReadLine());
                Console.WriteLine("Quel est ton nom?");
                Personne.Add(Console.ReadLine());
                Console.WriteLine("Quel est ton age?");
                Personne.Add(Console.ReadLine());*/
                if (int.Parse(Personne[2]) > 1)
                {
                    Console.WriteLine("Bonjour " + Personne[0] + " " + Personne[1] + ".\nTu as " + Personne[2] + " ans.");
                }
                else if (int.Parse(Personne[2]) == 1 | int.Parse(Personne[2]) == 0)
                {
                    Console.WriteLine("Bonjour {0} {1}.\nTu as {2} an.", Personne[0], Personne[1], Personne[2]);
                }
                else
                {
                    Console.WriteLine($"Bonjour {Personne[0]} {Personne[1]}.\nTu n'est pas encore né.");
                }
            }
            else if (option == "6")
            {
                double prixBrut = 0;
                string c = "Y";

                while (c == "Y" | c == "y")
                {
                    prixBrut = double.Parse(PoserQuestion("Donner le prix brut"));
                    Console.WriteLine("le prix net est de : " + CalculerPrixNet(prixBrut) + " Euros");
                    c = PoserQuestion("Est-ce que tu veut calculer un autre prix TTC avec la TVA 20.6%\nY or N");
                };

            }
            else if (option == "42")
            {
                int i = 1;
                while (i < 10)
                {
                    Console.WriteLine("La Réponse!!!\a");
                    Console.ReadLine();
                    i++;
                }
            }
            else if (option == "69")
            {
                Console.WriteLine("Pervert ( ͡° ͜ʖ ͡°)");
            }
            else if (option == "666")
            {
                int i = 0;
                while (i < 333)
                {
                    Console.WriteLine("VIVE SATAN!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("VIVE TEEMO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    i++;
                }

            }
            else
            {
                Console.WriteLine("L'option n'est pas encore intégrée\nVeux tu retourner à l'accueil? Y ou N");
                string c = "";
                c = Console.ReadLine();
                if (c == "Y" | c == "y")
                {
                    Console.Clear();
                    goto Accueil;
                }
            }
        }
        static int AdditionBis(int a, int b)
        {
            int cc = 0;
            cc = a + b;
            return (cc);
        }
        static string PoserQuestion(string Question)
        {
            Console.WriteLine(Question);
            string saisie = Console.ReadLine();
            return saisie;
        }
        static double CalculerPrixNet(double prixBrut)
        {
            double prixNet = 0;
            prixNet = prixBrut + (prixBrut / 100 * 20.6);
            return prixNet;
        }
    }
}
