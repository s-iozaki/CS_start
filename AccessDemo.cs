using System;

class Myclass{
    private int alpha;
    int beta;
    public int ganma;

    public void SetAlpha(int a){
        alpha = a;
    }

    public int GetAlpha(){
        return alpha;
    }

    public void SetBeta(int a){
        beta = a;
    }

    public int GetBeta(){
        return beta;
    }

}

class AccsessDemo {
    static void Main(){
        Myclass ob = new Myclass();

        ob.SetAlpha(-99);
        ob.SetBeta(19);
        Console.WriteLine(ob.GetAlpha());
        Console.WriteLine(ob.GetBeta());
        ob.ganma = 10;
        Console.WriteLine(ob.ganma);
        
    }
}