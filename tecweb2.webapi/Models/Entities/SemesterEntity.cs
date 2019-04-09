using System;
using tecweb2.webapi.Models.Entities.Base;

namespace tecweb2.webapi.Models.Entities
{
    public class SemesterEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
        public int Year { get; set; }
    }
}