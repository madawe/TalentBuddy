using System;

class MyClass {

    public void copy_string(string s1, string s2, int p) {
       s1 = s1.Insert(p, s2);
        Console.WriteLine(s1);
    }
}