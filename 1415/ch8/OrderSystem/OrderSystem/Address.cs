using System;


namespace OrderSystem
{
    public class Address
    {
        private string number;
        private string street;
        private string town;
        private string postcode;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        

        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        

        public string Town
        {
            get { return town; }
            set { town = value; }
        }
        

        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

    }
}
