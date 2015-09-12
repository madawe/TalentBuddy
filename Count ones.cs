using System;

class MyClass {

    public void count_one(int a) {
        
        int value = a;
        int ones = 0;
        string binary = Convert.ToString(value, 2);
        
        foreach (int thing in binary){
            if (thing == '1'){
                ones++;
            }
        }
        Console.WriteLine(ones);
    }
       
}