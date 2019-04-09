using System;
using System.ComponentModel.DataAnnotations.Schema;
using tecweb2.webapi.Models.Entities.Base;

namespace tecweb2.webapi.Models.Entities
{
    public class CareerSubjectiveEntity : BaseEntity
    {
        public Guid CareerId { get; set; }
        public Guid SubjectiveId { get; set; }

        [ForeignKey("CareerId")]
        public CareerEntity Career { get; set; }
        [ForeignKey("SubjectiveId")]
        public SubjectiveEntity Subjective { get; set; }
    }
}