using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Timing;

namespace TaawonMVC.Models
{
  public  class UploadFiles:FullAuditedEntity
    {
        public UploadFiles()
        {
            CreationTime = Clock.Now;
            FileName = "";
            FileData = new byte[]{0};
            Type = "";
            SourceTable = "";
            SourceTableId = 0;
            Description = "";
            DateEntry = Clock.Now;
            UserId = 0;
            NoOfFiles = 0;
        }
        [StringLength(50)]
        public string FileName { get; set; }

        public byte[] FileData { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string SourceTable { get; set; }

        public int? SourceTableId { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public DateTime? DateEntry { get; set; }

        public int? UserId { get; set; }

        public int? NoOfFiles { get; set; }


    }
}
