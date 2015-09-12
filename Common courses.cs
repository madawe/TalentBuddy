using System;

class MyClass {

    public void get_common_courses(int[] courses1, int[] courses2) {
        int[] answers = new int[courses2.Length];
        int k = 0;
        
        for(int i = 0; i != courses1.Length; i++){
            for(int j = 0; j != courses2.Length; j++){
                if (courses1[i] == courses2[j]){
                    answers[k] = courses2[j];
                    k++;
                }
            }
        }
        
        //use a bubble sort to order array answers
        bool changed = true;
        int holder =0;
        
        while(changed == true){
            changed = false;
            //sorting the array answers to the last number actually added to it with K+1
            for(int i = 1; i != k+1; i++){
                if (answers[i - 1] > answers[i]){
                    holder = answers[i - 1];
                    answers[i - 1] = answers[i];
                    answers[i] = holder;
                    changed = true;
                }  
            }
        }
        
        for (int q = 1; q !=answers.Length; q++){
            //stop the trailing zero's from printing
            if (answers[q] != 0){
            Console.Write(answers[q] + " ");
            }
        }
        
        
    }
}