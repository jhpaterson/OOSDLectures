using System;
using System.ComponentModel;

namespace ObjectBindingDemo
{
    public class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void Changed(string propertyName)
        {
            PropertyChangedEventHandler handler=PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set {
                if (name != value)
                {
                    name = value;
                    Changed("Name");
                }
            }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set
            {
                if (address != value)
                {
                    address = value;
                    Changed("Address");
                }
            }
        }
    }
}
