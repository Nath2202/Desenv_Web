using System;
using System.ComponentModel.DataAnnotations.Schema;
using tecweb2.webapi.Models.Entities.Base;

namespace tecweb2.webapi.Models.Entities
{
    public class TeachingPlanItemEntity : BaseEntity
    {
        public Guid TeachingPlanId { get; set; }
        public Guid ItemId { get; set; }
        
        [ForeignKey("TeachingPlanId")] public TeachingPlanEntity TeachingPlan { get; set; }
        [ForeignKey("ItemId")] public ItemEntity Item { get; set; }
    }
}