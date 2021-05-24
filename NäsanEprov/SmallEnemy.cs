using System;
using System.Collections.Generic;

namespace NäsanEprov
{
    public class SmallEnemy : Enemy
    {
         //Genererar x och y position 
         //ändrar hp för SmallEnemy
        public SmallEnemy(){
            Random generator = new Random();
            x = generator.Next(1,10);
            y = generator.Next(1,10);
            hp = +1; 
        }
        
        
    }
}
