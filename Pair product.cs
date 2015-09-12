using System;

class MyClass {

    public void max_prod(int[] v) {
    
    int biggest = 0;
    int current = 0;
    
        for (int i = 0; i < v.Length - 1; i++)
        {
            current = v[i] * v[i+1];
            if (current > biggest)
            {
                if (current % 3 == 0)
                {
                    biggest = current;
                }
            }
        }
        Console.WriteLine(biggest);    
    }
}