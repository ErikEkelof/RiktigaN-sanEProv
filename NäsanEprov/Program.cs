using System;
using System.Collections.Generic; 

namespace NäsanEprov
{
    class Program
    {
        static void Main(string[] args)
        {

            //Frågar hur många SmallEnemy som ska skapas
            List<Enemy> enemies = new List<Enemy> ();  
            Console.WriteLine("Hur många små fiender ska skapas?");
            string svar1 = Console.ReadLine();

            Console.Clear();

            //Sedan omvandlas de till en int som lagras i Enemy listan 
            int svarint1;
            bool success = int.TryParse(svar1, out svarint1);

            for (int i = 0; i < svarint1; i++) {
                Enemy SmallEnemy = new SmallEnemy();
                enemies.Add(SmallEnemy);
            }

            Console.Clear();
            
            //Hur många fiender som ska skapas och sedan läggs de in i listan
            Console.WriteLine("Hur många stora fiender ska skapas?");
            string svar2 = Console.ReadLine();
            int svarint2;
            bool success2 = int.TryParse(svar2, out svarint2);

            for (int i = 0; i < svarint2; i++) {
                Enemy LargeEnemy = new LargeEnemy();
                enemies.Add(LargeEnemy);
            }

            Console.Clear();

            //Kollar var man vill attackera i X led
            System.Console.WriteLine("Var vill du anfalla i X-led?");
            string attackX = Console.ReadLine();
            int attackintx;
            bool success3 = int.TryParse(attackX, out attackintx);

            //Kollar var man vill attackera i Y led 
            System.Console.WriteLine("Var vill du anfalla i Y-led?");
            string attackY = Console.ReadLine();
            int attackintY;
            bool success4 = int.TryParse(attackY, out attackintY);


            //Kollar vilken position på enemies och om användarens svar är träff eller inte
            for (int i = 0; i < enemies.Count; i++) {
                
                if(enemies[i].x  == attackintx && enemies[i].y == attackintY)
                {
                    System.Console.WriteLine("Träff");
                }
                else
                {
                    System.Console.WriteLine("ingen träff");
                }

                Console.ReadLine();
            }
            
        }
    }
}
