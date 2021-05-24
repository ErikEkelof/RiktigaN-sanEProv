using System;
using System.Collections.Generic;

namespace NäsanEprov
{
    public class LargeEnemy : Enemy
    {
        public int xp; 
        public int hp = 2; 
        public LargeEnemy(int x, int y){
            Random generator = new Random();
            x = generator.Next(1,10);
            y = generator.Next(1,10);
        }
    }   
}
