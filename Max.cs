using System;

class MyClass {

    public void get_max(int a, int b) {
        // Given two integer numbers a and b
		//Your task is to
		//write a function that prints to the standard output (stdout) the maximum value between the two
		
        if (a > b) {
            Console.WriteLine(a);
        }
        
        if (b > a) {
            Console.WriteLine(b);
        }
        
        if (a == b ) {
            Console.WriteLine("They are the same size");
        }
    }
}