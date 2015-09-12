using System;

class MyClass {

    public void remove_substring(string s, int p, int n) {
        // Write your code here
        // To print results to the standard output you can use Console.WriteLine()
        // Example: Console.WriteLine("Hello world!");
        
        s = s.Remove(p-1, n);
        
        Console.WriteLine(s);
    }
}