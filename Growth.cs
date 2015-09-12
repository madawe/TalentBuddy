using System;

class MyClass {
    public void check_growth(int d1, int d2) {
        // Given two integer numbers d1 and d2 representing the unique visitors on a website on the first and second day             //since launch
        //Your task is to
        //write a function that prints to the standard output (stdout) the word:
        //"Increase" if the number of unique visitors is higher or at least equal with the ones in the first day
        //"Decrease" otherwise


        Console.WriteLine(d2 < d1 ? "Decrease" : "Increase");
    }
}