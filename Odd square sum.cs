using System;

class MyClass {

    public void odd_square_sum(int x, int y) {
        int sum = 0;
            for (int i = x; i <=y; i++){
                if (i % 2!=0){
                sum = (sum + (i*i));
                }
            }
        Console.WriteLine(sum);   
    }
}