using System;
using System.ComponentModel.DataAnnotations.Schema;
using tecweb2.webapi.Models.Entities.Base;
using tecweb2.webapi.Models.Enums;

namespace tecweb2.webapi.Models.Entities
{
    public class ItemEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ItemTypeEnum Type { get; set; }

        public Guid SubjectiveId { get; set; }
        
        [ForeignKey("SubjectiveId")] public SubjectiveEntity Subjective { get; set; }
    }
}