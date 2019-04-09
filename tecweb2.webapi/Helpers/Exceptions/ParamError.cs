namespace tecweb2.webapi.Helpers.Exceptions
{
    public class ParamError
    {
        public string Message { get; set; }

        public int Code { get; set; }
        
        public string Param { get; set; }
    }
}