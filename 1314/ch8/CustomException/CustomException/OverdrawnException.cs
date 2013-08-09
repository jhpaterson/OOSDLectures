using System;

namespace CustomException
{
    public class OverdrawnException : Exception
    {
        private string message;

        public override string Message
        {
            get { return message; }
        }

        public OverdrawnException()
        {
            message = "Insufficient funds available, no further information available";
        }

        public OverdrawnException(decimal balance)
        {
            message = String.Format(
                "Insufficient funds available, new balance would be {0:c}", balance);
        }
    }
}
