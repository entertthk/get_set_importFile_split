using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getter_setter
{   
    class Person
    {
        string name;
        string gender;
        int age;
        string id;

        public Person(string _name, string _gender, int _age, string _id)
        {
            Name = _name;
            Gender = _gender;
            Age = _age;
            Id = _id;
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == "Male" || value == "Female")
                {
                    gender = value;
                }
                else
                {
                    gender = "unicorn";
                }
            }
        }
        public string Id
        {
            get { return id; }
            set
            {
                if (value.Length == 11)
                {
                    id = value;
                }
                else
                {
                    id = "undefined";
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {

                if (value >= 0 )
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        { 
            Person newPerson = new Person("John", "Male", 34, "38112155hhvl17");
            Console.WriteLine($"A new person {newPerson.Name}");
            newPerson.Name = "Joan";  //kirjutab nime üle
            Console.WriteLine($"A new person {newPerson.Name}");
            Console.WriteLine($"A new person {newPerson.Gender}");
            Console.WriteLine($"A new person with id {newPerson.Id}");

            Console.ReadLine();
        }
    }
}
