using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace TaawonMVC.Models
{
  public  interface IUploadFilesManager:IDomainService
  {
      Task<UploadFiles> Create(UploadFiles entity);
  }
}
