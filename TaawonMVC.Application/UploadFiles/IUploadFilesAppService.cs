using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using TaawonMVC.UploadFiles.DTO;

namespace TaawonMVC.UploadFiles
{
  public  interface IUploadFilesAppService:IApplicationService
  {
      Task Create(CreateUploadFilesInput input);
  }
}
