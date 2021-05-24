using System;
using System.Collections.Generic;

namespace NäsanEprov
{
    public class LargeEnemy : Enemy
    {
        //Xp int fuktionen 
        public int xp; 
        //Genererar x och y position 
         //ändrar hp för LargeEnemy
        public LargeEnemy(){
            Random generator = new Random();
            x = generator.Next(1,10);
            y = generator.Next(1,10);
            hp = +2;
        }
    }   
}
