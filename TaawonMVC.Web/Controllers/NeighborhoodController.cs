using Abp.Web.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaawonMVC.Neighborhood;
using TaawonMVC.Neighborhood.DTO;
using TaawonMVC.Web.Models.Neighborhood;

namespace TaawonMVC.Web.Controllers
{
    public class NeighborhoodController : AbpController
    {
        private readonly INeighborhoodAppService _neighborhoodAppService;

        public NeighborhoodController(INeighborhoodAppService neighborhoodAppService)
        {
            _neighborhoodAppService = neighborhoodAppService;

        }
        // GET: Neighborhood
        public ActionResult Index()
        {
            var neighborhoods = _neighborhoodAppService.GetAllNeighborhood();
            var neighborhoodViewModel = new NeighborhoodViewModel
            {
             Neighborhoods=neighborhoods
            };

            return View("Index",neighborhoodViewModel);
        }

        public ActionResult NeighborhoodEditModal(int userId)
        {
            var NeighborhoodInput = new getNeighborhoodIntput
            {
              Id= userId
            };

            var neighborhoodById = _neighborhoodAppService.getNeighborhoodById(NeighborhoodInput);

            var neighborhoodViewModel = new NeighborhoodViewModel
            {
             Neighborhood =neighborhoodById 
            };

            return View("_EditUserModal", neighborhoodViewModel);
        }
    }
}