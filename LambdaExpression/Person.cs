using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class Person
    {
        public int SSN;
        public string name;
        public int age;
        public string address;
        public Person(int SSN, string name, int age, string address)
        {
            this.SSN = SSN;
            this.name = name;
            this.age = age;
            this.address = address;
        }


        public static void AddRecords(List<Person> list)
        {
            list.Add(new Person(101, "raj", 67, "test"));
            list.Add(new Person(102, "raja", 6, "test"));
            list.Add(new Person(103, "rani", 15, "test"));
            list.Add(new Person(104, "ram", 10, "test"));
            list.Add(new Person(105, "rajesh", 40, "test"));
            foreach (Person person in list)
            {
                Console.WriteLine(person.name);
            }
        }
        public static void RetiveTopRecord(List<Person> persons)
        {
            foreach (Person person in persons.FindAll(e => (e.age <= 60)))
            {
                Console.WriteLine("Name " +person.name+ "Age" +person.age);
            }
        }
        public static void RetrieveRecord(List<Person> persons)
        {
            foreach (Person person in persons.FindAll(e => (e.age >= 13 && e.age <= 18))) 
            {
                Console.WriteLine("Name " + person.name + "Age" + person.age);
            }
        }

            static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            AddRecords(list);
            //RetiveTopRecord(list);
            RetrieveRecord(list);
        }
    }
}
