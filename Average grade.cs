using System;

class MyClass {

    public void compute_average_grade(int[] grades) {
        int total = 0;
        foreach (int i in grades) {total += i;}
        Console.WriteLine(total/grades.Length);
        
    }
}