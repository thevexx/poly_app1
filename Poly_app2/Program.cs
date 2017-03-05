using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly_app2
{
    class Program
    {
        static void Main(string[] args)
        {
            // afficher un message dans la fenetre console
            Console.Write("HELLO WORLD");

            // declaration d'une variable a de type entier et l'initialiser a 5
            int a = 5;

            // declaration d'une variable b de type reel et l'initialiser a 10.2
            float b = 10.2F;

            // declaration d'une variable c de type booleen et l'initialiser a vrai
            bool c = true;

            // affectation a la variable c une valeur faux
            c = false;

            // declaration d'une variable d de type caractere et l'initialiser a 'a'
            char d = 'a';
            
            a = 10;

            a = a + a;

            // l'execution de la fenetre console s'interempu en attendent l'utilisateur de saisir.
            Console.ReadKey();
        }
    }
}
