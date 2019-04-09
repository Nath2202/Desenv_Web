using System;
using System.Runtime.Serialization;

namespace tecweb2.webapi.Helpers.Exceptions
{
    public class InvalidArgumentException : ArgumentException
    {
        public int Code { get; set; }

        public InvalidArgumentException(int code)
        {
            Code = code;
        }
        
        public InvalidArgumentException(string message, ExceptionEnum code) : base(message)
        {
            Code = (int)code;
        }

        public InvalidArgumentException(string message, int code) : base(message)
        {
            Code = code;
        }

        public InvalidArgumentException(string message, Exception innerException, int code) : base(message, innerException)
        {
            Code = code;
        }

        public InvalidArgumentException(string message, string paramName, int code) : base(message, paramName)
        {
            Code = code;
        }
        
        public InvalidArgumentException(string message, string paramName, ExceptionEnum code) : base(message, paramName)
        {
            Code = (int)code;
        }

        public InvalidArgumentException(string message, string paramName, Exception innerException, int code) : base(message, paramName, innerException)
        {
            Code = code;
        }

        protected InvalidArgumentException(SerializationInfo info, StreamingContext context, int code) : base(info, context)
        {
            Code = code;
        }
    }
}