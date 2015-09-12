using System;

class MyClass {

    public void is_sorted(int[] grades) {
        int onezero = 2;
        for(int i = 1; i < grades.Length; i++){
            if( grades[i-1] > grades[i]){
                onezero = 0;
                i = grades.Length;
            }
            else{
                    onezero = 1;
            }   
        }
        Console.WriteLine(onezero);
    }
}