using System;

namespace ClassTutorial
{
    class Program //this is a class that already exists, can create more than one class in a file
    {
        static void Main(string[] args) //main method starts your program, when main ends your program shuts down
        {
            var mathlib = new MathLib();
            var x = 10;
            var y = 6;
            var inc = mathlib.Inc(x);
            Console.WriteLine($"Inc {x} is {inc}");
            var mod = mathlib.Mod(x, y);
            Console.WriteLine($"{ x} mod { y} is {mod}");
            var Result = mathlib.Add(x, y);
            Console.WriteLine($"Answer is {Result}");
            Result = mathlib.Sub(x, y);
            Console.WriteLine($"Answer is {Result}");
            Result = mathlib.Mult(x, y);
            Console.WriteLine($"Answer is {Result}");
            Result = mathlib.Div(x, y);
            Console.WriteLine($"Answer is {Result}");



            //template for what "students" are going to look like: here it's name property and print method
            //var fred = new Student(); //create instance with new + name of class + () + ;
            ////set name to value (only property in class)
            //fred.Name = "Fred"; //var that points to instance + property bc could be other student instances
            //fred.SAT = 1000;
            //var wilma = new Student(); //creating a new student instance without any data
            ////**Each piece of data must be unique every piece of data needs its own var**
            //wilma.Name = "Wilma";
            ////must start with var to differentiate student
            //wilma.SAT = 2000;
            //var barney = new Student();
            //barney.Name = "Barney";
            //barney.SAT = 1200; //doesn't matter where put statements, executed in order they're found
            //var message = wilma.Print(1); //need something in () now that we have added it to the print method in class
            //Console.WriteLine(message);
            //message = fred.Print(2);
            //Console.WriteLine(message);
            //barney.Print(3);
            //barney.SAT = barney.SAT + 20; //adding 20 to his score, can also do barney.SAT += 20;
            //barney.Print(4);
            //several instances of same class within all different variables bc always have to point to the
            //instance/var you're looking to act on
        }
    } // new class must be after the closing } for the previous class, don't put inside of the other class if putting in same window

}
