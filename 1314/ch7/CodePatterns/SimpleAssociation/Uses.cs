
namespace SimpleAssociation
{
    public class Uses
    {
         // an example instance variable
        private string someProperty;

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
        public Uses(string someProperty)
        {
            this.someProperty = someProperty;
        }

        /// <summary>
        /// IMPLEMENTATION: this method uses the related object through a method parameter
        /// </summary>
        /// <param name="used">the related object to be used</param>
        /// <returns>the result of sending a message to the used object</returns>
        public string Use(Used used)
        {
            // send a message to used object
            return used.SomeProperty;
        }

        /// <summary>
        /// IMPLEMENTATION: this method uses the related object through a local variable
        /// </summary>
        /// <returns>the result of sending a message to the used object</returns>
        public string SomeMethod(string value)
        {
            Used used = new Used(value);
            // send a message to used object
            return used.SomeProperty;
        }

        /// <summary>
        /// IMPLEMENTATION: this method uses the related object through a method return value
        /// </summary>
        /// <returns>the returned object</returns>
        public Used GetUsed(string value)
        {
            return new Used(value);
        }
    }
}
