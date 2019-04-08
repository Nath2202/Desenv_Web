using System;
using System.ComponentModel.DataAnnotations.Schema;
using tecweb2.webapi.Models.Entities.Base;

namespace tecweb2.webapi.Models.Entities
{
    public class UserSubjectiveEntity : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid SubjectiveId { get; set; }
        public bool Master { get; set; }

        [ForeignKey("UserId")]
        public UserEntity User { get; set; }
        
        [ForeignKey("SubjectiveId")]
        public SubjectiveEntity Subjective { get; set; }
    }
}