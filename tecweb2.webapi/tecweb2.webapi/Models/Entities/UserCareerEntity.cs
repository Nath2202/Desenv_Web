using System;
using System.ComponentModel.DataAnnotations.Schema;
using tecweb2.webapi.Models.Entities.Base;

namespace tecweb2.webapi.Models.Entities
{
    public class UserCareerEntity : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid CareerId { get; set; }
        
        [ForeignKey("UserId")] public UserEntity User { get; set; }
        [ForeignKey("CareerId")] public CareerEntity Career { get; set; }
    }
}