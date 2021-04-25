using System;

interface IMyInterface{
    void Start();
    void Stop();
}

class MyClass :IMyInterface{
    public void Start(){
        Console.WriteLine("starting ....");
    }

    public void Stop(){
        Console.WriteLine("Stopping ...");
    }
}

class MyClass2 {}

class Test<T> where T : IMyInterface{
    T obj ;
    public Test(T o){
        obj = o;
    }

    public void Activate(){
        obj.Start();
        obj.Stop();
    }
}

class InterfaceConstraintDemo{
    static void Main(){
        MyClass objA = new MyClass();
        MyClass2 objB = new MyClass2();

        Test<MyClass> t1 = new Test<MyClass>(objA);
        t1.Activate();

        //Test<MyClass2> t2 = new Test<MyClass2>(objB);
        //t2.Activate();
    }
}