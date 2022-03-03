using Microsoft.AspNetCore.Mvc;
using WebApplication2.Entities;
using WebApplication2.Interfaces.Services;

namespace WebApplication2.Controllers
{
    public class RegionController : Controller
    {
        private readonly IRegionServices _regionService;
        private readonly IStateServices _stateServices;

        public RegionController(IRegionServices regionService, IStateServices stateServices)
        {
            _regionService = regionService;
            _stateServices = stateServices;
        }

        public IActionResult Index()
        {
            return View(_regionService.GetAllRegion());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Region region)
        {
            _regionService.AddRegion(region);
            return RedirectToAction("Index");
        }

        public IActionResult GetRegionDetails(int id)
        {
            var region = _regionService.GetRegion(id);
            if (region == null)
            {
                return NotFound();
            }

            return View(region);
        }

        public IActionResult Update(int id)
        {
            var getRegion = _regionService.GetRegion(id);
            if (getRegion == null)
            {
                return NotFound();
            }

            return View(getRegion);
        }

        [HttpPost]
        public IActionResult Update(Region region, int id)
        {
            _regionService.Update(region, id);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteRegion(int id)
        {
            var delRegion = _regionService.GetRegion(id);
            if (delRegion == null)
            {
                return NotFound();
            }

            return View(delRegion);
        }

        [HttpPost, ActionName("DeleteRegion")]
        public IActionResult DeleteRegion(int id, Region region)
        {
            _regionService.DeleteRegion(id);
            return RedirectToAction("Index");
        }

        public IActionResult GetRegionByState(int id)
        {
            var check = _stateServices.GetRegionByState(id);
            ;
            if (check == null)
            {
                return NotFound();
            }

            var getSate = _stateServices.GetRegionByState(id);
            return View(getSate);
        }

    }
}