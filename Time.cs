using System;

class MyClass {

    public void convert_seconds(int seconds) {
    
    TimeSpan duration = new TimeSpan(0, 0, 0, seconds);
    string output = null;
    output = duration.ToString(@"hh\:mm\:ss"); 
    Console.WriteLine(output);

      
    }
}