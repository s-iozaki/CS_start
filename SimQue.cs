using System;
using System.Linq;

class SimpQuery{
    static void Main(){
        int[] nums = {1,-2,3,0,-4,5};

        var posNums = nums.Where(n => n > 0);
        
        Console.WriteLine("The positive value in nums:");
        foreach(int i in posNums) Console.Write(i);
    }
}