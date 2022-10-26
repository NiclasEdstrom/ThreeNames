using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2
{
    public class Person
    {

        // Creating a Person Class
        public string name = "";
        public string age = "";

        // Constructor to take values from input
        public Person(string name, string age)
        {
            this.name = name;
            this.age = age;
        }
        // Override ToString get name and age as a string
        public override string ToString()
        {
            return name + " " + age; 
        }












    }
    //public string? Name { get; set; }
    //public int Age { get; set; }

    //public override string ToString()
    //{
    //    return string.Format("[{0}] {1}", this.Name, this.Age);

    //}








}
