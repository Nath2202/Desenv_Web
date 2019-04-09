using System;
using System.ComponentModel.DataAnnotations.Schema;
using tecweb2.webapi.Models.Entities.Base;
using tecweb2.webapi.Models.Enums;

namespace tecweb2.webapi.Models.Entities
{
    public class TeachingPlanLogEntity : BaseEntity
    {
        public DateTimeOffset Date { get; set; }

        public TeachingPlanStatusEnum Status { get; set; }

        public Guid TeachingPlanId { get; set; }
        
        [ForeignKey("TeacingPlanId")] public TeachingPlanEntity TeachingPlan { get; set; }

    }
}