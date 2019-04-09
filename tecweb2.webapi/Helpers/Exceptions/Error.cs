using System.Collections.Generic;

namespace tecweb2.webapi.Helpers.Exceptions
{
    public class Error
    {
        public string Message { get; set; }

        public int Code { get; set; }
    }

    public class Errors
    {
        public List<string> Messages { get; set; }
        public int Code { get; set; }
    }
}