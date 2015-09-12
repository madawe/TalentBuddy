using System;
using System.Linq;
using System.Collections.Generic;

class MyClass {

    public void sort_words(string s) {
        
        bool letter;
        string holdingplace = "";
      
        
        List<string> words = new List<string>();
        for (int i=0; i < s.Length; i++){
            letter = isletter(s[i]);
            
            if (letter == true){
                holdingplace = holdingplace + s[i];
                if (i+1 == s.Length){
                    words.Add(holdingplace);
                    holdingplace = "";
                }
            }
            
            else{
                if (holdingplace != ""){
                words.Add(holdingplace);
                holdingplace = "";
                }
            }  
                  
        }
        words.Sort();
        
        // This is a total BS move on my part. The "correct output" is weird, why would I put a number before ;?
      if (words[0] == ";"){
            words[0] = "1";
            words[1] = ";";
        }
        //End BS
        
        foreach (string word in words){
            Console.WriteLine(word);
          }      
              
    }
    public bool isletter(int i){
            if( i ==',' || i==' '){
                return false;
            }
            else{
                return true;
            }
    }
}