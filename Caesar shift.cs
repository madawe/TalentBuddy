using System;

class MyClass {

    public void caesar_shift(string s) {
        // Write your code here
        // To print results to the standard output you can use Console.WriteLine()
        // Example: Console.WriteLine("Hello world!");
    
        char[] array = s.ToCharArray();
        int shift = 1;
       // Console.WriteLine(s);
        for (int i = 0; i < array.Length; i++){
            char letter = array[i];
            letter = (char)(letter + shift);
            if (letter == 33){
                continue;
            }
            if (letter > 90){
        		letter = (char)(letter - 26);
	        }
	        else if (letter < 65 ){
		    letter = (char)(letter + 26);
	        }
        array[i] = letter;
        }
        Console.WriteLine(array);
	    
        
    }
}