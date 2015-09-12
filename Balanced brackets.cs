using System;

class MyClass {

    public void balanced_brackets(string s) {

        
        int center = (s.Length/2)-1;
        int j = center+1;
        string balance = "Balanced";
        int nestfactor = 0;
        //First Checking if the String is Symmetrical
        for (int i = center; i >= 0; i--, j++){
            if(s[i] == s[j]){
                balance = "Unbalanced";
                break;
            }
        }
        //Now Checking to Make Sure it is Nested Correctly
        for (int k = 0; k < center; k++){
            if (s[k] == '('){
                nestfactor++;
            }
            if (s[k] == ')'){
                nestfactor--;
            }
        }
        
        if (nestfactor <= 0){
            balance = "Unbalanced";
        }
        Console.WriteLine(balance);   
    }
}