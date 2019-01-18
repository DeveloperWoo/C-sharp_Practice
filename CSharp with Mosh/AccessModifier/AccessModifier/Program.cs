using System;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            /*
             * using setters and getters, 
             * we know what it does but cannot know how it works inside the method. 
             * This is called information hiding
            */
            person.SetBirthday(new DateTime(2019, 1, 18)); 
            Console.WriteLine(person.GetBirthdate()); //2019-01-18 12:00:00 AM
        }
    }
}
