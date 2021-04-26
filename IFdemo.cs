#define EXPERIMENTAL
using System;

class Ifdemo1{
    static void Main(){
        #if EXPERIMENTAL
        Console.WriteLine("Compiled for experimental varsion.");
        #endif
        
        Console.WriteLine("This is is all versions.");
    }
}