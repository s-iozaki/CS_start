using System;

class Block{
    int a, b, c;
    int volume;

    public Block(int i,int j,int k){
        a=i;
        b=j;
        c=k;
        volume = a * b * c; 
    }
    public bool SameBlock(Block ob){
        if ((ob.a == a) & (ob.b == b) & (ob.c == c)) return true;
        else return false;
    }

    public bool Samevolume(Block ob){
        if(ob.volume == volume) return true;
        else return false;
    }
}

class PassOb{
    public static void Main(){
        Block ob1 = new Block(10,2,5);
        Block ob2 = new Block(10,2,5);
        Block ob3 = new Block(4,5,5);

        Console.WriteLine("ob1 same dimensions as ob2:" + ob1.SameBlock(ob2));
        Console.WriteLine("ob1 same dimensions as ob3:" + ob1.SameBlock(ob3));
        Console.WriteLine("ob1 same volume as ob3:" + ob1.Samevolume(ob3));
    }
}
