using System;

class MyClass {

    public void sort_locations(int a, int b, int c) {
        // Write your code here
        // To print results to the standard output you can use Console.WriteLine()
        // Example: Console.WriteLine("Hello world!");
        int d;
        if (a > b) {
        d = b; b = a; a = d;
        }
        if (b > c) {
        d = c; c = b; b = d;
        }
        
        if (a > b) {
        d = b; b = a; a = d;
        }
        
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
            
    }
}