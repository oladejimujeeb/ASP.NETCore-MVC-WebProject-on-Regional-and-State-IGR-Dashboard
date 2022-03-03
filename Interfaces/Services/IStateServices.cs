using System.Collections.Generic;
using WebApplication2.Entities;

namespace WebApplication2.Interfaces.Services
{
    public interface IStateServices
    {
        bool AddState(State state);
        bool DeleteState(int id);
        IList<State> GetAllState();
        State GetState(int id);
        State UpdateState(State state, int id);
        IList<State> GetRegionByState(int id);
    }
}