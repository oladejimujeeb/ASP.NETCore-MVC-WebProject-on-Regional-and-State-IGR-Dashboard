using System.Collections.Generic;
using WebApplication2.Entities;

namespace WebApplication2.Interfaces.Repositories
{
    public interface IStateRepository
    {
        bool AddState(State state);
        bool DeleteState(int id);
        IList<State> GetAllState();
        State GetState(int id);
        bool UpdateState(State state);
        IList<State> GetRegionByState(int id);
    }
}