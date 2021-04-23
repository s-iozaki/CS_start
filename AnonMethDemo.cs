using System;

delegate void CountIt();

class AnonMetDemo{
    static void Main(){
        CountIt count = delegate{ //匿名メソッド、以下のコードブロックを参照するデリゲートが作成される。
            for(int i=0; i<=5; i++)
                Console.Write(i + " ");
        };

        count();
        Console.WriteLine();
    }

}