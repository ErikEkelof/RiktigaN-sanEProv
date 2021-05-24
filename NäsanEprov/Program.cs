using System;
using System.Collections.Generic; 

namespace NäsanEprov
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SmallEnemy> SmallEnemy = new List<SmallEnemy> ();  
            Console.WriteLine("Hur många små fiender ska skapas?");
            string svar1 = Console.ReadLine();

            int svarint1;
            bool success = int.TryParse(svar1, out svarint1);

            
            Console.WriteLine("Hur många små fiender ska skapas?");
            string svar2 = Console.ReadLine();

            int svarint2;
            bool success2 = int.TryParse(svar2, out svarint2);



        }
    }
}
