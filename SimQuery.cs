using System;
using System.Linq;

class SimQuery{
    static void Main(){
        int[] nums = {1,-2,3,0,-4,5};

        var posNums = from n in nums
                      where n > 0
                      select n;
        Console.WriteLine("The positive value is nums:");
        foreach(int i in posNums) Console.WriteLine(i);
    }
}