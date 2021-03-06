using System;

delegate void MyEventHandler();

class MyEvent{
    public event MyEventHandler SomeEvent;

    public void Fire(){
        if(SomeEvent != null)
        SomeEvent();

    }
}

class EventDemo{
    static void Handler(){
        Console.WriteLine("Event occured");
    }

    static void Main(){
        MyEvent evt = new MyEvent();

        evt.SomeEvent += Handler;

        evt.Fire();
    }
}