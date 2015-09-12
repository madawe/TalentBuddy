using System;

class MyClass {

    public void compute_prediction(int n, int w) {
        float fn=(float)n;
        float growth =(float).07;
        
        for (int i = 1; i <= w; i++) {
            fn = fn + (fn * growth);
        }
        n = (int)fn;   
        Console.WriteLine(n);
        
    }
}