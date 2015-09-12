using System;

class MyClass {

    public void fizzbuzz(int n) {
    
        for(int i = 0; i <= n; i++){
              
            if(i == 0){
                continue;
            }
            if(i % 5 != 0 && i % 3 != 0|| n == 1){
                Console.WriteLine(i);
                continue;
            }
            if (i % 3 == 0 && i % 5==0){
                Console.WriteLine("FizzBuzz");
                continue;
            }
            if (i % 3 == 0 ){
                Console.WriteLine("Fizz");
            }
            if (i % 5 == 0 ){
                Console.WriteLine("Buzz");
            }
            
            
            
        }
        
    }
}