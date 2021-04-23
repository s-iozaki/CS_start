using System;

delegate string StrMod(string str);

class DelegateTest{
    static string ReplaceSpace(string a){
        Console.WriteLine("Replaces spaces with hyphens.");
        return a.Replace(' ','-');
    }

    static string RemoveSpace(string a){
        string temp = "";
        int i;

        Console.WriteLine("Removeing spaces.");
        for(i=0;i<a.Length;i++)
            if(a[i] != ' ')temp += a[i];
        return temp;
    }

    static string Reverse(string a){
        string temp = "";
        int i, j;

        Console.WriteLine("Reversign string");
        for(j=0,i=a.Length-1; i >= 0; i--,j++)
            temp += a[i];
        return temp;
    }

    static void Main() {
        StrMod strOp = ReplaceSpace;
        string str;

        str = strOp("This is a test");
        Console.WriteLine("Resulting string: " + str);
        Console.WriteLine();

        strOp = RemoveSpace;
        str = strOp("This is a test");
        Console.WriteLine("Resulting string: " + str);
        Console.WriteLine();

        strOp = Reverse;
        str = strOp("This is a test");
        Console.WriteLine("Resulting string: " + str);
        Console.WriteLine();
    }


}