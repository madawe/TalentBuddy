using System;
using System.Linq;

class MyClass {

    public void find_missing_number(int[] v) {
        
        int i =1;
        while( i <= v.Length)
        {
            int b = Array.IndexOf(v, i);
            if (b == -1)
            {
                Console.WriteLine(i);
            }
            i++;
        }     
    }
}