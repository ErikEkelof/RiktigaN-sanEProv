using System;
using System.Collections.Generic; 

namespace NäsanEprov
{
    class Program
    {
        static void Main(string[] args)
        {

            //Frågar hur många SmallEnemy som ska skapas
            List<int> Enemy = new List<int> ();  
            Console.WriteLine("Hur många små fiender ska skapas?");
            string svar1 = Console.ReadLine();

            //Sedan omvandlas de till en int som lagras i Enemy listan 
            int svarint1;
            bool success = int.TryParse(svar1, out svarint1);
            Enemy.Add(svarint1);


            Console.WriteLine("Hur många stora fiender ska skapas?");
            string svar2 = Console.ReadLine();
            int svarint2;
            bool success2 = int.TryParse(svar2, out svarint2);
            Enemy.Add(svarint2);


            System.Console.WriteLine("Var vill du anfalla i X-led?");
            string attackX = Console.ReadLine();
            int attackintx;
            bool success3 = int.TryParse(attackX, out attackintx);

            System.Console.WriteLine("Var vill du anfalla i Y-led?");
            string attackY = Console.ReadLine();
            int attackintY;
            bool success4 = int.TryParse(attackY, out attackintY);


            //System.Console.WriteLine("Träffade" + Enemy.Count() + " ");

        }
    }
}
