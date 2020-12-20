using System;
using System.Collections.Generic;
using System.Linq;

namespace CommaSeparatedEditing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = "foo, bar, baz, stack, overflow, server, fault,endingentry";
            List<String> Items = list.Split(',').Select(i => i.Trim()).Where(i => i != string.Empty).ToList(); //Split them all and remove spaces
            Items.Remove("fault"); //or whichever you want
            Items.Add("My New Entry");
            string modifiedlist = String.Join(", ", Items.ToArray());

            Console.WriteLine(modifiedlist);
            Console.ReadLine();
        }
    }
}
