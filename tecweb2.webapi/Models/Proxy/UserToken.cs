using System;
using System.Collections.Generic;

namespace tecweb2.webapi.Models.Proxy
{
    public class UserToken
    {
        public Guid? Id { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}