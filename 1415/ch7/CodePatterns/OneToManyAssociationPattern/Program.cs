using System;
using System.Collections.Generic;

namespace OneToManyAssociationPattern
{
    /// <summary>
    /// a test program to demonstrate the pattern in action
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            // set up test objects
            Whole whole1 = new Whole("whole 1");
            Part part1 = new Part("part 1");
            Part part2 = new Part("part 2");
            Part part3 = new Part("part 3");
            Part part4 = new Part("part 4");
            whole1.AddPart(part1);
            whole1.AddPart(part2);
            whole1.AddPart(part3);
            whole1.AddPart(part4);
            Console.WriteLine("Whole object ({0}) will now send messages to its Part objects:",
                whole1.SomeProperty);
            Console.WriteLine(whole1.GetDetails());

            // part objects can be shared with another whole
            Whole whole2 = new Whole("whole 2");
            whole2.AddPart(part2);
            whole2.AddPart(part3);
            Console.WriteLine("Whole object ({0}) will now send messages to its Part objects:",
                whole2.SomeProperty);
            Console.WriteLine(whole2.GetDetails());

            // find a part object
            string targetProperty = "part 2";
            Console.WriteLine("Asking for: {0}...", targetProperty);
            Part part = whole1.GetPart(targetProperty);
            Console.WriteLine("Found: {0}",part.SomeProperty);

            // remove a part object
            targetProperty = "part 3";
            Console.WriteLine("Removing: {0}...", targetProperty);
            whole1.RemovePart(targetProperty);

            // get collection and traverse
            List<Part> parts = whole1.Parts;
            foreach (Part p in parts)
            {
                Console.Write("{0}  ", p.SomeProperty);
            }

            Console.ReadLine();
        }
    }
}
