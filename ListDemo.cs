using System;
using System.Collections.Generic;

class ListDemo{
    static void Main(){
        List<int> lst = new List<int>();

        Console.WriteLine("Initial number of elements:" + lst.Count);
        Console.WriteLine("Initial capacity:" + lst.Capacity);

        Console.WriteLine();

        Console.WriteLine("adding 5 elements");

        lst.Add(1);
        lst.Add(-2);
        lst.Add(14);
        lst.Add(9);
        lst.Add(88);

        Console.WriteLine("Number of elements :" + lst.Count);
        Console.WriteLine("Capacity :" + lst.Capacity);

        Console.Write("Contens:");
        for(int i=0; i<lst.Count; i++)
        Console.Write(lst[i] + " ");
        Console.Write("\n");

        Console.WriteLine("Removing 2 elements");

        lst.Remove(-2);
        lst.Remove(88);

        Console.WriteLine("Number of elements:" + lst.Count);

        Console.Write("Contens:");
        foreach(int i in lst)
        Console.Write(i + " ");
        Console.Write("\n");

        Console.WriteLine("Adding 10 elements");
        for(int i =0;i<10;i++)
        lst.Add(i);

        Console.WriteLine("Number of elements after adding 10:" + lst.Count);
        Console.WriteLine("Capacity:" + lst.Capacity);
        Console.Write("Contens:");
        foreach(int i in lst)
        Console.Write(i + " ");
        Console.Write("\n");

        Console.WriteLine("Change first three elements");
        lst[0]=-10;
        lst[1]=-lst[1];
        lst[2]=99;

        Console.Write("Contents:");
        foreach(int i in lst)
        Console.Write(i + " ");
        Console.Write("\n");   
    }
}