using System.Collections;
using System.Collections.Generic;
using WebApplication2.Entities;

namespace WebApplication2.Interfaces.Repositories
{
    public interface IRegionRepository
    {
        bool AddRegion(Region region);
        bool DeleteRegion(int id);
        bool UpdateRegion(Region region);
        IList<Region> GetAllRegion();
        Region GetRegion(int id);
        
    }
}