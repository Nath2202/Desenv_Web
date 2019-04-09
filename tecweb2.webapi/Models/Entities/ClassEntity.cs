using System;
using System.ComponentModel.DataAnnotations.Schema;
using tecweb2.webapi.Models.Entities.Base;

namespace tecweb2.webapi.Models.Entities
{
    public class ClassEntity : BaseEntity
    {
        public DayOfWeek DayOfWeek { get; set; }

        public Guid SubjectiveId { get; set; }
        
        [ForeignKey("SubjectiveId")]
        public SubjectiveEntity Subjective { get; set; }
    }
}