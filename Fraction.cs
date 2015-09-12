using System;

class MyClass {

    public void compute_fraction(string s) {
            int over=0;
            int under=0;
        double ss = Convert.ToDouble(s);
        for(int i=1; i<1000; i++){
            if ((ss*i)%1==0){
                over=i;
                under=(int)(ss*i);
                break;
            }
        }
        Console.Write(under);
        Console.Write("/");
        Console.Write(over);
        
            
        
    }
}