using System;

class MyClass {

    public void print_float(string s) {
        
        string[] sstring = s.Split('.');
        
        long beforedec = Convert.ToInt64(sstring[0],2);
        long afterdec = Convert.ToInt64(sstring[1],2);
        int length = sstring[1].ToString().Length;
        Console.WriteLine(beforedec+(afterdec/Math.Pow(2, length)));
	
        
    }
}