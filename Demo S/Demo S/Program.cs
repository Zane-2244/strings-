using System;


namespace Demo_S
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Zane";
            var lastName = "Bridle";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            var names = new string[3] { "Chris", "jack", "mark" };
            var formattedNames = string.Join(",", names);
           

            var text = @"Hi jack
Look into the following paths
c:\folder1\folder2
c:\\folder3\folder4";
            Console.WriteLine(text);

        }
    }
}
