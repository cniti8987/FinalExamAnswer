using System;

namespace Nitifinalexam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Audit a = new Audit();
            Child c = new Child();

            a.FirstName = "Nitiksha";
            a.LastName = "Patel";

            c.FirstName = "Amit";
            c.LastName = "Amin";


        }

        public class Audit
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
       public  class Child
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
    }
}
