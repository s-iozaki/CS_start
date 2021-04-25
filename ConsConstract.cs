using System;

class MyClass{
    public MyClass(){
        Console.WriteLine("Creating a MyClass instance");
    }
}

class Test<T> where T :new(){
    T ob;
    public Test(){
        Console.WriteLine("Creating a Test instance");
        ob = new T();
    }
} 

class ConsConstraintDemo{
    static void Main(){
        Test<MyClass> t = new Test<MyClass>();
    }
}