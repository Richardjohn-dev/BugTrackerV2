using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Domain.Entities.Common
{
    public abstract class BaseDomainEntity
    {
        //Base fields that every class/domain entity will need
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTimeOffset DateCreated { get; set; }
        public string CreatedBy { get; set; } // could update to Id later..
      
        [DataType(DataType.Date)]
        public DateTimeOffset? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }

    }
}
