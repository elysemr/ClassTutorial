using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTutorial
{
    class Student
    {
        public string Name { get; set; } //public (access), string (type), Name (name)
                                         //if public, get and set are public (anyone can read, edit)
                                         //most properties will look like the name line
        private int _SAT = 800; //no other class can access it, use _ for internal variables only, where data stored
        public int SAT
        {  //make it so anyone can read value but if edit ensure can only be between 400 and 1600
            get { return _SAT; } //value held in _SAT, get/set will allow user to interact with it
            set
            {               //checks value they try to set it to before put it in

                if (value < 400 || value > 1600)
                {
                    Console.WriteLine("Invalid SAT score.");
                }
                else
                {
                    this._SAT = value;
                }
            }
        }

        public void Print() //can pass parameters in here if need/want
        {
            Console.WriteLine($"name:{this.Name} sat:{this.SAT}"); //will print whatever we put in as name for student
                                          //when inside your class and referencing property from inside, use this. to reference what accessing
                                          //usually "this" is optional as long as they know what you're referring to (usually fine unless duplicates)
        }
    }
}
