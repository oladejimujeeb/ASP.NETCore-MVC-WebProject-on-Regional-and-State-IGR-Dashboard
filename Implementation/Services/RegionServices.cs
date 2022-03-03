using System;
using System.Collections.Generic;
using WebApplication2.Entities;
using WebApplication2.Implementation.Repositories;
using WebApplication2.Interfaces.Repositories;
using WebApplication2.Interfaces.Services;
namespace WebApplication2.Implementation.Services
{
    public class RegionServices:IRegionServices
    {
        private readonly IRegionRepository _regionRepository;

        public RegionServices(IRegionRepository regionRepository)
        {
            _regionRepository = regionRepository;
        }

        public bool DeleteRegion(int id)
        {
            var region = _regionRepository.GetRegion(id);
            if (region == null)
            {
                throw new Exception("Region not found");
            }

            return _regionRepository.DeleteRegion(id);
        }

        public bool AddRegion(Region region)
        {
            var newRegion = new Region()
            {
                Name = region.Name, Population = region.Population, IGR = region.IGR
            };
            return _regionRepository.AddRegion(newRegion);
        }

        public IList<Region> GetAllRegion()
        {
            return _regionRepository.GetAllRegion();
        }

        public Region GetRegion(int id)
        {
            var region =  _regionRepository.GetRegion(id);
            /*if (region == null)
            {
                throw new Exception($"Region with {id} not found"); 
            }*/
            return _regionRepository.GetRegion(id);
        }

        public Region Update(Region region, int id)
        {
            var getRegion = _regionRepository.GetRegion(id);
            if (getRegion == null)
            {
                throw new Exception($"Region wth {id} not found");
            }

            getRegion.Name = region.Name;
            getRegion.Population = region.Population;
            getRegion.IGR = region.IGR;
             _regionRepository.UpdateRegion(getRegion);
             return region;
        }
    }
}