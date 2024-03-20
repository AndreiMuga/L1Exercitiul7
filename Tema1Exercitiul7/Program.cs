using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Lab1Ex7
/*
Ex 7
Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica
daca x este divizibil cu y.
 In cazul in care x este divizibil cu y, programul va afisa “divizibil” iar in caz contrar,
“indivizibil”.
 */
{
    public class Program 
    { public static void Main(string[] args) 
        { 
            int primulNumar;
            int alDoileaNumar;
            int divizibil;
            Console.WriteLine("Introduceti primul numarul: ");
            primulNumar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar: ");
            alDoileaNumar = Convert.ToInt32(Console.ReadLine());
            divizibil = primulNumar % alDoileaNumar;
            if (divizibil == 0)
            { 
                Console.WriteLine("Numerele sunt dibizibile");
            } 
            else
            {
                Console.WriteLine("Numerele sunt indivizibile");
            }
        }
    }
}