using System;

class MyClass {

    public void max_grade(int[] grades) {
       
        int winner=0;
        for(int i = 0; i != grades.Length; i++) {
            if (grades[i] > winner){
                winner = grades[i];
            }
        }
        
        Console.WriteLine(winner);
        
    
    }
}