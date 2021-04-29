using System;

class RefTest{
    public void Sqr(ref int i){
        i = i *i;
    }
}

class RefDemo{
    static void Main(){
        RefTest  ob  = new RefTest();

        int a = 10;

        Console.WriteLine("a before call : " + a);
        ob.Sqr(ref a);

        Console.WriteLine("a after call:" + a);
    }
}