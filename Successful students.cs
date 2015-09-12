using System;

class MyClass {

    public void count_successful_students(int[] grades, int min_grade) {
        int answer = 0;
        foreach (int i in grades){
            if (i >= min_grade){
                answer++;
            }
        }
        Console.WriteLine(answer);
            
    }
}