using System;
using System.Collections.Generic;
using System.Text;

namespace Quantity_Measurement
{
    // Custom Exception 
    public class CustomException : Exception
    {
        // Enum  Type Of Exception
        public enum ExceptionType
        {
            INPUT_NULL, TYPE_NOT_MATCH
        }
        public ExceptionType type;

        //Constructor
        public CustomException(ExceptionType type)
        {
            this.type = type;
        }

        public CustomException(ExceptionType type, String message) : base(message)
        {
            this.type = type;
        }
    }
}
