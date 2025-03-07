﻿using System.ComponentModel.DataAnnotations;

namespace FinanceHub.Entity.DomainObjects
{
    public class BaseDomainObject
    {
        public BaseDomainObject()
        {
            Id = Guid.NewGuid().ToString("N");
        }

        [Key, Required]
        public string Id { get; set; }
        public DateTime CreatedAtTime { get; set; } = DateTime.Now;
        public DateTime? UpdatedAtTime { get; set; }
        public DateTime? DeletedAtTime { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool Status { get; set; } = true;
    }
}