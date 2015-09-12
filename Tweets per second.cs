using System;
using System.Linq;
using System.Collections.Generic;

class MyClass {

    public void tweets_per_second(int[] tps, int k) {
       
        int winner = 0;
        int life = k-1;
        int adjustedlife = k-1;
        int tpslength = tps.Length;
        
        for (int i=0 ; i < tpslength; i++)
        { 
            //if the new number is the same as the new number its life needs to be refreshed no need to check its life
            if (winner == tps[i])
            {
                life = adjustedlife;
                Console.WriteLine(winner);
                continue;
            }
            if (tps[i] > winner)
            {
                winner = tps[i];
                life = adjustedlife;
                Console.WriteLine(winner);
                continue;
            }
            if (winner > tps[i])
            {
                Console.WriteLine(winner);
                life--;
            }
            
            //Check if Winner is still alive
             if (life <= 0)
            {
                winner =0;
                life =0;

                //find a new winner
                int it=(i-k+2);
                if (it < 0)
                {
                    it = 0;
                }
                while (it < i-2)
                {
                    if(tps[it] > winner)
                    {
                        winner = tps[it];
                        life = ((k + it) - i)-1;      
                    }
                    it++;
                }
             }
   
        }
            
    }
}