using tecweb2.webapi.Models.Entities.Base;

namespace tecweb2.webapi.Models.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Roles { get; set; }
    }
}