using System;

class MyClass {

    public void select_substring(string s, int p1, int p2) {
        // Write your code here
        // To print results to the standard output you can use Console.WriteLine()
        // Example: Console.WriteLine("Hello world!");
        for(int i = p1-1; i != p2; i++){ 
        Console.Write(s[p1-1]);
            p1++;
        }
        
    }
}