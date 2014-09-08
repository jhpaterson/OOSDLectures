
namespace SimpleAssociation
{
    public class Used
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
        public Used(string someProperty)
        {
            this.someProperty = someProperty;
        }
    }
}
