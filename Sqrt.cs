using System;

class MyClass {
   
    public void compute_sqrt(int n) {
        int divergence = n;
        int mindivergence=n;
        int answer = n;
        for(int i = 0; i < n; i++){
           divergence =(n-(i*i));
            if (divergence < mindivergence && divergence>0){
                mindivergence = divergence;
                answer=i;
            }
        }
        Console.WriteLine(answer);
    }
}