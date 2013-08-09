using System;

namespace OneToManyBidirectionalPattern
{
    /// <summary>
    /// represents the "part" in a whole-part relationship
    /// implements IEquatable so that it objects can be found in a collection
    /// </summary>
    public class Part : IEquatable<Part>
    {
        // an example instance variable
        private string someProperty;

        // IMPLEMENTATION: the object which contains this one
        private Whole whole;

        /// <summary>
        /// an example property
        /// </summary>
        public string SomeProperty1
        {
            get { return someProperty; }
            set { someProperty = value; }
        }

        /// <summary>
        /// the object which contains this one
        /// </summary>
        public Whole Whole
        {
            get { return whole; }
            set { whole = value; }
        }

        /// <summary>
        /// constructor for Part objects
        /// </summary>
        /// <param name="someProperty">value for the example property</param>
        /// <param name="whole">the whole object to associate this object with</param>
        public Part(string someProperty, Whole whole)
        {
            this.someProperty = someProperty;

            // IMPLEMENTATION: ensure consistency
            this.whole = whole;
            whole.AddPart(this);   
        }

        /// <summary>
        /// constructor for Part objects
        /// </summary>
        /// <param name="someProperty">value for the example property</param>
        public Part(string someProperty)
        {
            this.someProperty = someProperty;
            this.whole = null;
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
        /// required to implement IEquatable
        /// </summary>
        /// <param name="p">the object to test</param>
        /// <returns></returns>
        public bool Equals(Part p)
        {
            if (p != null)
            {
                return this.someProperty == p.someProperty;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// overrides Equals method in Object
        /// </summary>
        /// <param name="obj">the object to test</param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null) return base.Equals(obj);

            if (!(obj is Part))
                throw new InvalidCastException("The 'obj' argument is not an Employee object.");
            else
                return Equals(obj as Part);
        }

        /// <summary>
        /// overrides GetHashCode method in Object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            // Which is preferred?

            return base.GetHashCode();

            //return this.FooId.GetHashCode();
        }

    }
}
