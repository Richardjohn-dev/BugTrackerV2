using BugTracker.Domain.Entities.Common;
using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Domain.Entities
{
    public class TicketAttachment : UserTicketEntity
    {      
        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile FormFile { get; set; }

        [DisplayName("File Name")]
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        [DisplayName("File Extension")]
        public string FileContentType { get; set; }     

    }
}
