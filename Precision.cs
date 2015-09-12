using System;

class MyClass {

    public void precision(double p1, double p2, int v) {
    double temp=0;
    temp = v*p1;
    double rounded = Math.Round(temp, MidpointRounding.AwayFromZero);
    Console.Write(rounded);
    Console.Write(" ");
    Console.Write(v-rounded);
    }
}