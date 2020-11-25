using System;

namespace nombres_occurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string texte;
            Console.WriteLine("Programme d'affichage du nombre d'occurences \nVeuillez indiquer le texte que vous souhaitez (au moins 120 caractères)");
            texte = Console.ReadLine();
            if (texte.Length < 120)
            {
                Console.WriteLine("Texte trop court!");
            }
            else
            {
                char[] lettres = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                for (int i = 0; i < lettres.Length; i++)
                {
                    int compteur = 0;
                    for (int y = 0; y < texte.Length; y++)
                    {
                        if (lettres[i]==texte [y])
                        {
                            compteur++;
                            
                        }
                        
                    }
                    Console.WriteLine("Nombre d'occurances pour la lettre " + lettres[i] +" : "+ compteur);
                }
                
            }
        }
    }
}
