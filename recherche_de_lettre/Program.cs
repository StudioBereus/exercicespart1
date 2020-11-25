using System;

namespace recherche_de_lettre
{
    class Program
    {
        static void Main(string[] args)
        {
            string recommencer = "oui";
            while (recommencer == "oui") 
            {
                string chaine;
                char caractere;
                int occurance = 0;
                Console.WriteLine("Veuillez écrire votre chaîne de caractères");
                chaine = Console.ReadLine();
                if (chaine.Length==1 && chaine[0] =='.')
                {
                    Console.WriteLine("La chaîne est vide !");
                }
                else
                {
                    Console.WriteLine("Veuillez à présent indiquer le caractère dont vous souhaitez le nombre occurences");
                    caractere = char.Parse(Console.ReadLine());
                    for (int i = 0; i < chaine.Length; i++)
                    {
                        if (chaine[i] == caractere)
                        {
                            occurance++;
                        }
                        
                    }
                    Console.WriteLine("Le caractère est écrit : " + occurance + " fois");
                }
                Console.WriteLine("Recommencer? oui/non");
                recommencer = Console.ReadLine(); 
            }
        }
    }
}
