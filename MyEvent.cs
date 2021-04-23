using System;

delegate void MyEventHandler();

class MyEvent{
    public event MyEventHandler SomeEvent;

    public void Fire(){
        if(SomeEvent != null)
        SomeEvent();

    }
}


class X{
    public void Xhandler(){
        Console.WriteLine("Event received by X object");
    }
}

class Y{
    public void Yhandler(){
        Console.WriteLine("Event received by Y object");
    }
}

class EventDemo{
    static void Handler(){
        Console.WriteLine("Event occured");
    }

    static void Main(){
        MyEvent evt = new MyEvent();
        X xob = new X();
        Y yob = new Y();

        evt.SomeEvent += xob.Xhandler;
        evt.SomeEvent += yob.Yhandler;
        evt.SomeEvent += Handler;

        evt.Fire();
        Console.WriteLine("");

        evt.SomeEvent -= xob.Xhandler;
        Console.WriteLine("After removing xob.XHandler");
        evt.Fire(); 
    }
}