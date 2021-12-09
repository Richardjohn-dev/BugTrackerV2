using BugTracker.Domain.Entities.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Domain.Entities
{
    public class Project : BaseDomainEntity
    {
       
        [Required]
        [StringLength(100)]
        [DisplayName("Title")]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTimeOffset StartDate { get; set; }

        [DisplayName("End Date")]
        [DataType(DataType.Date)]
        public DateTimeOffset? EndDate { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile FormFile { get; set; }

        [DisplayName("File Name")]
        public string ImageFileName { get; set; }
        public byte[] ImageFileData { get; set; }
        [DisplayName("File Extension")]
        public string ImageContentType { get; set; }

        [DisplayName("Completed")]
        public bool IsComplete { get; set; }

        // Nav
        public virtual ICollection<ApplicationUser> Members { get; set; } = new HashSet<ApplicationUser>();
        public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();


    }
}
