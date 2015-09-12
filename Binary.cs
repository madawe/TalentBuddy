using System;

class MyClass {

    public void convert_to_binary(int n) {
        int value = n;
        string binary = Convert.ToString(value, 2);
        Console.WriteLine(binary);
    }
}