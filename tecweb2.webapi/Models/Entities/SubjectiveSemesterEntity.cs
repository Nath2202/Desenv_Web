using System;
using System.ComponentModel.DataAnnotations.Schema;
using tecweb2.webapi.Models.Entities.Base;

namespace tecweb2.webapi.Models.Entities
{
    public class SubjectiveSemesterEntity : BaseEntity
    {
        public Guid SubjectiveId { get; set; }

        public Guid SemesterId { get; set; }

        public DateTimeOffset EndDateTeachingPlan { get; set; }

        [ForeignKey("SubjectiveId")] public SubjectiveEntity Subjective { get; set; }

        [ForeignKey("SemesterId")] public SemesterEntity Semester { get; set; }
    }
}