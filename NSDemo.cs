using System;
class NSDemo{
    static void Main(){
        counter.CountDown cd1 = new counter.CountDown(10);
        int i;

        do{
            i = cd1.Count();
            Console.Write(i + " ");
        }while(i > 0);
        Console.WriteLine();

        counter.CountDown cd2 = new counter.CountDown(20);

        do{
            i = cd2.Count();
            Console.Write(i + " ");
        }while(i > 0);
        Console.WriteLine();

        cd2.Reset(4);
        do{
            i = cd2.Count();
            Console.Write(i + " ");
        }while(i > 0);
        Console.WriteLine();
    }
}