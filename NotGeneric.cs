using System;

class NotGeneric{
    object ob;
    public NotGeneric(object o){
        ob = o;
    }
    public object Getob(){
        return ob;
    }
}

class NonGenDemo{
    static void Main(){
        NotGeneric iob;

        iob = new NotGeneric(88);

    int v = (int) iob.Getob();
    Console.WriteLine("iob is an instance of NotGeneric.\n" + "Thereor , the value returned by Getob() " +
    "is object .\n it must be cast to int : " + v + "\n");

    NotGeneric strob = new NotGeneric("Non-Generic class");
    string str = (string) strob.Getob();
    Console.WriteLine("iob is an instance of NotGeneric.\n" + "Thereor , the value returned by Getob() " +
    "is also object .\n it must be cast to string : " + str + "\n");

    iob = strob;
    v = (int) iob.Getob();
    }
}