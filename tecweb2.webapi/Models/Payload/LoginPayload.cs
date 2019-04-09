using System.ComponentModel.DataAnnotations;

namespace tecweb2.webapi.Models.Payload
{
    public class LoginPayload
    {
        [MinLength(1, ErrorMessage = "É necessário enviar um usuário.")]
        public string Username { get; set; }
        
        
        [MinLength(6, ErrorMessage = "É necessário enviar uma senha com no mínimo 6 dígitos.")]
        public string Password { get; set; }
    }
}