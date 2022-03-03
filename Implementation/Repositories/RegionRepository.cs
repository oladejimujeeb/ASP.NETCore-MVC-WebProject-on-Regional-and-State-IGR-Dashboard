using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Context;
using WebApplication2.Entities;
using WebApplication2.Interfaces.Repositories;

namespace WebApplication2.Implementation.Repositories
{
    public class RegionRepository:IRegionRepository
    {
        private readonly ApplicationContext _context;

        public RegionRepository(ApplicationContext context)
        {
            _context = context;
        }
        
        public bool AddRegion(Region region)
        {
            _context.Regions.Add(region);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteRegion(int id)
        {
            var region = _context.Regions.Find(id);
            _context.Remove(region);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateRegion(Region region)
        {
            _context.Regions.Update(region);
            _context.SaveChanges();
            return true;
        }

        public IList<Region> GetAllRegion()
        {
           return _context.Regions.ToList();
        }

        public Region GetRegion(int id)
        {
           return _context.Regions.Find(id);
        }
    }
}