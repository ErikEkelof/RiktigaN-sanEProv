using System;
using System.Collections.Generic;

namespace NäsanEprov
{
    public class SmallEnemy : Enemy
    {
        public int hp = 1; 
        public SmallEnemy(int x, int y){
            Random generator = new Random();
            x = generator.Next(1,10);
            y = generator.Next(1,10);
        }
        
        
    }
}
