using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication2.Entities;
using WebApplication2.Interfaces.Services;

namespace WebApplication2.Controllers
{
    public class StateController:Controller
    {
        private readonly IStateServices _stateServices;
        private readonly IRegionServices _regionServices;

        public StateController(IStateServices stateServices, IRegionServices regionServices)
        {
            _stateServices = stateServices;
            _regionServices = regionServices;
        }
        public IActionResult Index()
        {
            return View(_stateServices.GetAllState());
        }
        public IActionResult Create()
        {
            var region = _regionServices.GetAllRegion().Distinct();
            
            ViewData["Regions"] = new SelectList(region, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(State state)
        {
            _stateServices.AddState(state);
            return RedirectToAction("Index");
        }
        public IActionResult GetDetails(int id)
        {
            var region = _stateServices.GetState(id);
            if (region == null)
            {
                return NotFound();
            }

            return View(region);
        }
        public IActionResult Update(int id)
        {
            var getRegion = _stateServices.GetState(id);
            if (getRegion == null)
            {
                return NotFound();
            }

            return View(getRegion);
        }
        [HttpPost]
        public IActionResult Update(State state, int id)
        {
            _stateServices.UpdateState(state, id);
            return RedirectToAction("Index");
        }
        
        public IActionResult DeleteState(int id)
        {
            var delRegion = _stateServices.GetState(id);
            if (delRegion == null)
            {
                return NotFound();
            }
            return View(delRegion);
        }
        [HttpPost,ActionName("DeleteState")]
        public IActionResult DeleteRegion(int id, Region region)
        {
            _stateServices.DeleteState(id);
            return RedirectToAction("Index");
        }

        public IActionResult GetRegionByState(int id)
        {
            var check = _stateServices.GetRegionByState(id);;
            if (check == null)
            {
                return NotFound();
            }

            var getSate = _stateServices.GetRegionByState(id);
            return View(getSate);
        }
    }
}