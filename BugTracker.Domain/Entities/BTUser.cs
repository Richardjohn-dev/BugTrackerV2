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
    public class BTUser : BaseDomainEntity
    {
        //public int id { get; set; }
        //[DataType(DataType.Date)]
        //public DateTimeOffset DateCreated { get; set; }
        //public string CreatedBy { get; set; } // could update to Id later..

        //[DataType(DataType.Date)]
        //public DateTimeOffset? LastModifiedDate { get; set; }
        //public string LastModifiedBy { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [NotMapped]        
        [Display(Name = "First Name")]
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile AvatarFormFile { get; set; }

        [DisplayName("Avatar")]
        public string AvatarFileName { get; set; }
        public byte[] AvatarFileData { get; set; }
        [Display(Name = "File Extension")]
        public string AvatarContentType { get; set; }

        public virtual ICollection<Project> Projects { get; set; } = new HashSet<Project>();

    }
}
