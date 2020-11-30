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
                int occurence = 0;
                do
                {
                    Console.WriteLine("Veuillez écrire votre chaîne de caractères");
                    chaine = Console.ReadLine();
                }
                while(chaine[chaine.Length -1] != '.');
                   
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
                            occurence++;
                        }
                        
                    }
                    if (occurence == 0)
                    {
                        Console.WriteLine("Le carcatère n'est pas présent dans la chaine");
                    }
                    else 
                    {
                    
                    Console.WriteLine("Le caractère est écrit : " + occurence + " fois");
                    }
                }
                Console.WriteLine("Recommencer? oui/non");
                recommencer = Console.ReadLine(); 
            }
        }
    }
}
