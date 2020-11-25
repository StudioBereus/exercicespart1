using System;

namespace nombre_de_jeunes
{
    class Program
    {
        static void Main(string[] args)
        {
            string recommencer = "oui";
            while (recommencer == "oui")
            {
                Console.WriteLine("Programme de calcul du nombre de jeunes");
                int[] personnes = new int[20];
                for (int i = 0; i < personnes.Length; i++)
                {
                    Console.WriteLine("Veuillez indiquer le nom de la personne n°" + (i + 1));
                    personnes[i] = int.Parse(Console.ReadLine());
                }
                int jeunes = 0;
                int plusDeVingt = 0;
                int vingt = 0;
                int nouveauNé = 0;
                int centenaire = 0;
                int casImpossible = 0;
                foreach (int âge in personnes)
                {
                    if (âge < 20 && âge > 0)
                    {
                        jeunes++;
                    }
                    else if (âge > 20 && âge < 100)
                    {
                        plusDeVingt++;
                    }
                    else if (âge == 20)
                    {
                        vingt++;
                    }
                    else if (âge == 0)
                    {
                        nouveauNé++;
                    }
                    else if (âge >= 100)
                    {
                        centenaire++;
                    }
                    else if (âge < 0)
                    {
                        casImpossible++;
                    }
                    else
                    {
                        Console.WriteLine("Entrée incorrecte");
                    }  
                }
                if (jeunes == 20)
                {
                    Console.WriteLine("Il n'y a que des jeunes !");
                }
                else if (plusDeVingt == 20)
                {
                    Console.WriteLine("Il n'y a pas de jeunes !");
                }
                else if (vingt == 20)
                {
                    Console.WriteLine("Il n'y a que des gens de 20 ans !");
                }
                else if (nouveauNé == 20)
                {
                    Console.WriteLine("Il n'y a que des nouveaux-nés !");
                }
                else if (centenaire == 20)
                {
                    Console.WriteLine("Il n'y a que des centenaires !");
                }
                else if (casImpossible == 20)
                {
                    Console.WriteLine("Il n'y a que des cas impossibles !");
                }
                else
                {
                    Console.WriteLine("Il y a : " + jeunes + " jeune(s) \nIl y a : " + plusDeVingt + " personne(s) qui ont plus de 20 ans \nIl y a : " + vingt + " personne(s) qui ont 20 ans");
                    Console.WriteLine("Il y a : " + nouveauNé + " de nouveau(x)-né(s) \nIl y a : " + centenaire + " centenaire(s) \nIl y a : " + casImpossible + " de cas impossible(s)");
                    
                }
                Console.WriteLine("Recommencer? oui/non");
                recommencer = Console.ReadLine();
            }
        }
        
    }
}
 