using System;

namespace RMDP.Utils.Exceptions
{
    public class InvalidPersianDateException : Exception
    {
        public InvalidPersianDateException() : base(string.Empty)
        {
        }

        public InvalidPersianDateException(string message)
            : base(message)
        {
        }

        public InvalidPersianDateException(string message, object value)
        {
            InvalidValue = value;
        }

        public object InvalidValue
        {
            get; private set;
        }
    }
}
