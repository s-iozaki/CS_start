using System;

delegate double Transform(double v);
delegate bool TestInts(int w, int V);

class ExpressionLambdaDemo{
    static void Main(){
        Transform reciprocal = n => 1.0/n;

        Console.WriteLine("The reciprocal of 4 is " + reciprocal(4.0));
        Console.WriteLine("The reciprocal of 10 is " + reciprocal(10.0));

        TestInts isFactor = (f,d) => f%d == 0;
        Console.WriteLine("Is 3 a factor of 9 ?" + isFactor(9,3));
        Console.WriteLine("Is 3 a factor of 10 ?" + isFactor(10,3));

    }
}