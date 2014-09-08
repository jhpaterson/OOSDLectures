using System;
using System.Collections.Generic;

namespace OneToManyCompositionPattern
{
    /// <summary>
    /// a test program to demonstrate the pattern in action
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            // set up test objects
            Whole whole = new Whole("the whole");
            whole.AddPart("part 1");
            whole.AddPart("part 2");
            whole.AddPart("part 3");
            whole.AddPart("part 4");
            Console.WriteLine("Whole object ({0}) will now send messages to its Part objects:",
                whole.SomeProperty);
            Console.WriteLine(whole.GetDetails());

            // find a part object
            string targetProperty = "part 2";
            Console.WriteLine("Asking for: {0}...", targetProperty);
            Part part = whole.GetPart(targetProperty);
            Console.WriteLine("Found: {0}",part.SomeProperty);

            // remove a part object
            targetProperty = "part 3";
            Console.WriteLine("Removing: {0}...", targetProperty);
            whole.RemovePart(targetProperty);

            // get collection and traverse
            List<Part> parts = whole.Parts;
            foreach (Part p in parts)
            {
                Console.Write("{0}  ", p.SomeProperty);
            }

            Console.ReadLine();
        }
    }
}
