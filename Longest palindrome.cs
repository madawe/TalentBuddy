using System;

class MyClass {
//this one is shameful, I should have done so many things in a object oriented way, also I basically copied and pasted the whole program rather than just changing a variable , I need to clean up this mess before I ever let anyone see it.
    public void longest_palind(string s) {
        int center = 0;
        int size = 0;
        int front = 0;
        int back =1;
        int recordsize = 0;
        int recordcenter =0;
        bool recordeven =false;
        bool even=false;
        bool pala=false;
        bool outofbounds=false;
        
        for(int i = 0; i < s.Length-1; i++){        
            if (s[i-front]==s[i+back]){ 
                pala=true;
                outofbounds=false;
                size=0;
                front=0;
                back=1;
                while(pala==true && outofbounds==false){ 
                    even=true;
                    size++;
                    center=i;
                    front--;
                    back++;
                    if(size > recordsize){
                        recordsize = size;
                        recordcenter = center;
                        recordeven = even;
                    }
                    //test to see if the new larger zone is going to be out of bounds
                    if(i+back >= s.Length-1){
                        outofbounds=true;
                        front=0;
                        back=1;
                    }
                    //test if the increased front and back made for a longer pala
                    if (s[i+front]==s[i+back] && outofbounds==false){
                        pala=true;
                    }
                    else{
                        pala=false;
                    }       
                }
            }           
        }      
        for(int i = 1; i < s.Length-1; i++){
            front=-1;
            if (s[i+front]==s[i+back]){
                pala=true;
                outofbounds=false;
                size=0;
                front=-1;
                back=1;
                while(pala==true && outofbounds==false){ 
                    even=false;
                    size++;
                    center=i;
                    front--;
                    back++;
                    if(size > recordsize){
                        recordsize = size;
                        recordcenter = center;
                        recordeven = even;
                    }
                    //test to see if the new larger zone is going to be out of bounds
                    if(i+back >= s.Length-1){
                        outofbounds=true;
                        front=-1;
                        back=1;
                    }
                    if(i+front <= 1){
                        outofbounds=true;
                        front=-1;
                        back=1;
                    }
                    //test if the increased front and back made for a longer pala
                    if (s[i+front]==s[i+back] && outofbounds==false){
                        pala=true;
                    }
                    else{
                        pala=false;
                        front=-1;
                        back=1;
                    }              
                }
            }                   
        }    
        for(int answer=(recordcenter-recordsize);answer<= (recordcenter+recordsize); answer++){
            Console.Write(s[answer]);
        }
    }
}