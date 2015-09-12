using System;

class MyClass {

    public void sort_students(int[] numbers) {
    
        bool changed = true;
        int holder = 0;
        
        while(changed == true){
            changed = false;
            
            for(int i = 1; i != numbers.Length; i++){
                
                if (numbers[i - 1] > numbers[i]){
                    holder = numbers[i - 1];
                    numbers[i - 1] = numbers[i];
                    numbers[i] = holder;
                    changed = true;
                }  
            }
        }
        foreach(var item in numbers){
          Console.Write("{0}", item + " ");
        }
        
                    
    }               
}
 