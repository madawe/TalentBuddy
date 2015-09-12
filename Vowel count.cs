using System;
using System.Linq;

class MyClass {

    public void count_vowels(string s) {

        
        int count = 0;
        foreach (char c in s) {
        if (c == 'a') count++;
        if (c == 'e') count++;
        if (c == 'i') count++;
        if (c == 'o') count++;
        if (c == 'u') count++;
        if (c == 'A') count++;
        if (c == 'E') count++;
        if (c == 'I') count++;
        if (c == 'O') count++;
        if (c == 'U') count++;
       
        }
        Console.WriteLine(count);
    }
}