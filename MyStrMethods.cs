using System;

class MyStrMethods {

    public string ReverseStr(string str){
        string result = "";

        foreach(char ch in str)
        result = ch +  result;

    return result;
    }
}


class Myclass : MyStrMethods{}

class MyClass2{}

class Test<T> where T : MyStrMethods{
    T obj;

    public Test(T o){
        obj = o;
    }

    public void ShowReverse(string str){
        string revStr = obj.ReverseStr(str);
        Console.WriteLine(revStr);
    }
}

class BaseClassConstraintDemo{
    static void Main(){
        MyStrMethods objA = new MyStrMethods();
        Myclass objB = new Myclass();
        MyClass2 objC = new MyClass2();
        
        Test<MyStrMethods> t1 = new Test<MyStrMethods>(objA);

        t1.ShowReverse("this tis a test.");

        Test<Myclass> t2 = new Test<Myclass>(objB);

        t2.ShowReverse("More Testing.");

        // Test<MyClass2> t3 = new Test<MyClass2>(objC);
        // t3.ShowReverse("Error!");

    }
}