using System;

class MyClass {

    public void count_digits(string s) {
        int count = 0;
        foreach (char l in s){
            if(l > 48 && l < 57){
                count++;                
            }
        }
        Console.WriteLine(count);
            
    }
}