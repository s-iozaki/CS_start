using System;

class MyGenClass<T>{
    T ob;
    public MyGenClass(T o){
        ob = o;
    }

    public T Getob(){
        return ob;
    }

}

class GenericsDemo{
    static void Main(){
        MyGenClass<int> iob;

        iob = new MyGenClass<int>(88);

        int v = iob.Getob();
        Console.WriteLine("iob is an instance of MyGenClass<int>. \n"+
        "the value returned by Getob() : "+ v + "\n");

        MyGenClass<string> strob = new MyGenClass<string>("Generics Demo");

        string str = strob.Getob();
        Console.WriteLine("iob is an instance of MyGenClass<string>. \n"+
        "the value returned by Getob() : "+ str + "\n");

    }
}