using System;

namespace tecweb2.webapi.Models.Proxy
{
    public class TokenProxy
    {
        public string Token { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
        
    }
}