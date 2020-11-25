using System;

namespace chercher_un_nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programme de recherche d'un nombre");
            int[] tableau = new int[5] { 1, 8, 12, 16, 20 };
            int recherche = Array.IndexOf(tableau, 12);
            if (recherche == -1)
            {
                Console.WriteLine("Non trouvé");
            }
            else
            {
                Console.WriteLine("Le nombre se trouve à l'index " +recherche);
            }
             
        }
    }
}
