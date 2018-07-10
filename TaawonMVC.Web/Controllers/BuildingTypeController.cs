using Abp.Web.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaawonMVC.BuildingType;
using TaawonMVC.BuildingType.DTO;
using TaawonMVC.Web.Models.BuildingType;
using TaawonMVC.Web.Models.Users;

namespace TaawonMVC.Web.Controllers
{
    public class BuildingTypeController : AbpController
    {
        private readonly IBuildingTypeAppService _buildingTypeAppService;
        public BuildingTypeController(IBuildingTypeAppService buildingTypeAppService)
        {
            _buildingTypeAppService = buildingTypeAppService;
        }
        // GET: BuildingType
       [Route("BuildingType/BuildingType")]
        public ActionResult BuildingType()
        {
            var BuildingTypes = _buildingTypeAppService.getAllBuildingtype();
            var buidlingTypes = new BuildingTypeViewModel
            {
                BuildingTypes=BuildingTypes
            };           
            return View("BuildingType", buidlingTypes);
        }

        public ActionResult EditUserModal(int userId)
        {
            var getBuidlingTypeInput = new GetBuidlingTypeInput
            {
             Id=userId
            };
            var BuildingTypeTypeOutput =  _buildingTypeAppService.getBuildingTypeById(getBuidlingTypeInput);
            var BuildingTypeViewModal = new BuildingTypeViewModel
            {
               buildingTypeOutput = BuildingTypeTypeOutput
            };
            return View("_EditUserModal", BuildingTypeViewModal);
        }
    }
}