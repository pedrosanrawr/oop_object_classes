using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //oop - classes and objects

            //p1 instantiation
            Person p1 = new Person();
            //p1 objects
            p1.firstName = "peter";
            p1.lastName = "dones";
            p1.age = 18;
            p1.sex = 'M';

            //p1 output
            Console.WriteLine("person 1");
            Console.WriteLine("name: " + p1.firstName + " " + p1.lastName);
            Console.WriteLine("age: " + p1.age);
            Console.WriteLine("gender: " + p1.sex);

            //p2 instantiation
            Person p2 = new Person();
            //p2 objects
            p2.firstName = "venice";
            p2.lastName = "don";
            p2.age = 18;
            p2.sex = 'F';

            //p2 output
            Console.WriteLine("\nperson 2");
            Console.WriteLine("name: " + p2.firstName + " " + p2.lastName);
            Console.WriteLine("age: " + p2.age);
            Console.WriteLine("gender: " + p2.sex);

            //p3 instatiation
            Person p3 = new Person();
            //p3 objects
            p3.firstName = "kiro";
            p3.lastName = "deus";
            p3.age = 20;
            p3.sex = 'M';

            //p3 output
            Console.WriteLine("\nperson 3");
            Console.WriteLine("name: " + p3.firstName + " " + p3.lastName);
            Console.WriteLine("age: " + p3.age);
            Console.WriteLine("gender: " + p3.sex);

            //p4 instantiation
            Person p4 = new Person();
            //p4 objects
            p4.firstName = "andrea";
            p4.lastName = "egana";
            p4.age = 20;
            p4.sex = 'F';

            //p4 output
            Console.WriteLine("\nperson 4");
            Console.WriteLine("name: " + p4.firstName + " " + p4.lastName);
            Console.WriteLine("age: " + p4.age);
            Console.WriteLine("gender: " + p4.sex);
        }
    }

    //class person
    class Person
    {
        //attributes
        public string lastName;
        public string firstName;
        public char sex;
        public int age;
    }
}
