using System.Collections.Generic;
using WebApplication2.Entities;

namespace WebApplication2.Interfaces.Services
{
    public interface IRegionServices
    {
        bool DeleteRegion( int id);
        IList<Region> GetAllRegion();
        Region GetRegion(int id);
        Region Update(Region region, int id);
        bool AddRegion(Region region);
    }
}