using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using TaawonMVC.Models;
using TaawonMVC.UploadFiles.DTO;

namespace TaawonMVC.UploadFiles
{
  public  class UploadFilesAppService:ApplicationService,IUploadFilesAppService
  {
      private readonly IUploadFilesManager _uploadFilesManager;

      public UploadFilesAppService(IUploadFilesManager uploadFilesManager)
      {
          _uploadFilesManager = uploadFilesManager;
      }
        public async Task Create(CreateUploadFilesInput input)
        {
            var outPut = Mapper.Map<CreateUploadFilesInput, Models.UploadFiles>(input);
            await  _uploadFilesManager.Create(outPut);
        }
    }
}
