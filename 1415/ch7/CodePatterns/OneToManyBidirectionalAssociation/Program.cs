using System;
using System.Collections.Generic;

namespace OneToManyBidirectionalPattern
{
    /// <summary>
    /// a test program to demonstrate the pattern in action
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            // set up test objects
            Whole whole = new Whole("whole 1");
            Part part1 = new Part("part 1", whole);
            Part part2 = new Part("part 2", whole);
            Part part3 = new Part("part 3", whole);
            Part part4 = new Part("part 4", whole);
            Console.WriteLine("Whole object ({0}) will now send messages to its Part objects:",
                whole.SomeProperty);
            Console.WriteLine(whole.GetDetails());
            Console.WriteLine("Part sends message to whole: {0}", part1.Whole.SomeProperty);


            // find a part object
            string targetProperty = "part 2";
            Console.WriteLine("Asking for: {0}...", targetProperty);
            Part part = whole.GetPart(targetProperty);
            Console.WriteLine("Found: {0}",part.SomeProperty);

            // remove a part object
            targetProperty = "part 3";
            Console.WriteLine("Removing: {0}...", targetProperty);
            whole.RemovePart(targetProperty);
            Console.WriteLine("Removed part, whole is null: {0}", part3.Whole==null);

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
