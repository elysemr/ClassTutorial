using System;

namespace ClassTutorial
{
    class Program //this is a class that already exists, can create more than one class in a file
    {
        static void Main(string[] args)
        {//template for what "students" are going to look like: here it's name property and print method
            var fred = new Student(); //create instance with new + name of class + () + ;
            //set name to value (only property in class)
            fred.Name = "Fred"; //var that points to instance + property bc could be other student instances
            fred.SAT = 1000;
            var wilma = new Student(); //creating a new student instance without any data
            //**Each piece of data must be unique every piece of data needs its own var**
            wilma.Name = "Wilma";
            //must start with var to differentiate student
            wilma.SAT = 2000;
            wilma.Print();
            fred.Print();
            //several instances of same class within all different variables bc always have to point to the
            //instance/var you're looking to act on
        }
    } // new class must be after the closing } for the previous class, don't put inside of the other class if putting in same window

}
