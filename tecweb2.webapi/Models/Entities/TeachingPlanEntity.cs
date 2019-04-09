using System;
using System.ComponentModel.DataAnnotations.Schema;
using tecweb2.webapi.Models.Entities.Base;

namespace tecweb2.webapi.Models.Entities
{
    public class TeachingPlanEntity : BaseEntity
    {
        public Guid MasterId { get; set; }

        [ForeignKey("MasterId")]
        public UserEntity Master { get; set; }

    }
}