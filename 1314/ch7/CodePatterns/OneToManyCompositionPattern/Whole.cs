using System;
using System.Collections.Generic;

namespace OneToManyCompositionPattern
{
    public class Whole
    {
        // IMPLEMENTATION: the collection of contained objects
        private List<Part> parts;   // Parts held in a List - modify if you want to use different data structure

        // an example instance variable
        private string someProperty;

        /// <summary>
        /// HELPER: gets the collection of Part objects
        /// </summary>
        public List<Part> Parts
        {
            get { return parts; }
        }

        /// <summary>
        /// an example property
        /// </summary>
        public string SomeProperty
        {
            get { return someProperty; }
            set { someProperty = value; }
        }

        /// <summary>
        /// constructor for Part objects
        /// </summary>
        /// <param name="someProperty">value for the example property</param>
        public Whole(string someProperty)
        {
            // IMPLEMENTATION: initialises the collection
            parts = new List<Part>();   
            this.someProperty = someProperty;
        }

        /// <summary>
        /// an example method which simply returns  some information
        /// the whole sends a message to each part
        /// the message here is simply a request for a property value
        /// </summary>
        /// /// <returns>a string resulting from sending a message to each part</returns>
        public string GetDetails()
        {
            string details = "";
            foreach (Part part in parts)
            {
                details += part.SomeProperty + "\n";
            }
            return details;
        }

        /// <summary>
        /// HELPER: creates and adds a new Part object
        /// </summary>
        /// <param name="someProperty">example property value for the object to be added</param>
        public void AddPart(string someProperty)
        {
            Part part = new Part(someProperty);
            parts.Add(part);
        }

        /// <summary>
        /// HELPER: returns a Part object from the collection
        /// identified by a property of the Part object
        /// </summary>
        /// <param name="someProperty">the property which identifies the Part to be found</param>
        /// <returns>the required Part</returns>
        public Part GetPart(string someProperty)
        {
            Part target = new Part(someProperty);
            int pos = parts.IndexOf(target);     // makes use of Equals method of Part
            if (pos != -1)
                return parts[pos];
            else
                return null;
        }

        /// <summary>
        /// HELPER: removes a Part object from the collection
        /// identified by a property of the Part object
        /// </summary>
        /// <param name="someProperty">the property which identifies the Part to be found</param>
        public void RemovePart(string someProperty)
        {
            Part target = new Part(someProperty);
            int pos = parts.IndexOf(target);    // makes use Equals method of Part
            if (pos != -1)
                parts.RemoveAt(pos);
        }
 
    }
}
