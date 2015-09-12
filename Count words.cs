using System;

class MyClass {

    public void count_words(string s) {
        // I know this can be done in like one line using LINQ or Regex but I am trying to learn
        // so I am doing it the hard way as a challenge to myself
        
        //
        
        int words = 0;
        
        for(int i = 0; i < s.Length; i++){
            if (s[i] != ' ' && s[i] != ','){
                if (s[i+1] == ' ' || s[i+1] ==  ','){
                    
                    words++;
                }   
            }
        }
         
       Console.WriteLine(words);
    }
}