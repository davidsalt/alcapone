using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.RedPill;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            RedPillClient client = new RedPillClient();

            var test3 = client.WhatShapeIsThis(3, 4, 5);
            Console.WriteLine(test3);
            var test1 = client.FibonacciNumber(5);
            Console.WriteLine(test1);            

            var test2 = client.ReverseWords("volkan van");
            Console.WriteLine(test2);            

            

            var test4 = client.WhatIsYourToken();
            Console.WriteLine(test4);
            Console.ReadLine();
        }
    }
}
