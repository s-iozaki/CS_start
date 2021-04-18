using System;

class TwoDShape{
    public double Width;
    public double Heigth;

    public void ShowDim(){
        Console.WriteLine("Width and height are" + Width + "and" + Heigth);
    }
}

class Triangle : TwoDShape {
    public string Style;
    public double Area(){
        return Width * Heigth / 2;
    }

    public void showStyle(){
        Console.WriteLine("Triangle is " + Style);
    }
}

class Shape{
    static void Main(){
        Triangle t1 = new Triangle();
        Triangle t2 = new Triangle();
        t1.Width = 4.0;
        t1.Heigth = 4.0;
        t1.Style = "isosceles";

        t2.Width = 8.0;
        t2.Heigth = 12.0;
        t2.Style = "right";

        Console.WriteLine("Info for t1 :");
        t1.showStyle();
        t1.ShowDim();
        Console.WriteLine("Aria is" + t1.Area());

        Console.WriteLine();

        Console.WriteLine("Info for t2:");
        t2.showStyle();
        t2.ShowDim();
        Console.WriteLine("Area is " + t2.Area());
    }
}