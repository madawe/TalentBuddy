using System;

class MyClass {

    public void longest_improvement(int[] grades) {
        // Write your code here
        // To print results to the standard output you can use Console.WriteLine()
        // Example: Console.WriteLine("Hello world!");
        
        int streak = 1;
        int maxstreak = 1;
        for(int i = 1; i< grades.Length; i++){
            if (grades[i] >= grades[i-1]){
                streak++;
            }
            if(streak > maxstreak){
                maxstreak = streak;
            }
            if(i == grades.Length){
                if(streak > maxstreak){
                    maxstreak = streak;
                }
            }
            if(grades[i] < grades[i-1]){
                streak = 0;
            }
            
            
        }
        Console.WriteLine(maxstreak+1); 
    }
}