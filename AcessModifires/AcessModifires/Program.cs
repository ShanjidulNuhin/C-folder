using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessModifires
{
    class Person
    {
        private DateTime _dateTime;/*private field (_dateTime)
        of Type = DateTime Which store the birth date of a person*/
        public void setBirthDate(DateTime birthdate)//this methode sets the -dateTime field to given birthDate
        {
            _dateTime = birthdate;
        }
        public DateTime GetBirthDate()//this methode returns the value of -dateTime
        {
            return _dateTime;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();//instance of the person class is created
            person.setBirthDate(new DateTime(2001, 1,2));
            Console.WriteLine(person.GetBirthDate());

            Console.ReadLine();
        }
    }
}
