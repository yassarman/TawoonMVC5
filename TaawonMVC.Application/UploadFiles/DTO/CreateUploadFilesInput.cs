using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;

namespace TaawonMVC.UploadFiles.DTO
{ 
    [AutoMap(typeof(Models.UploadFiles))]
  public  class CreateUploadFilesInput
    {
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
