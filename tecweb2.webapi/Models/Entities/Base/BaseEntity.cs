using System;
using System.ComponentModel.DataAnnotations;

namespace tecweb2.webapi.Models.Entities.Base
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        public bool Active { get; set; }
    }
}