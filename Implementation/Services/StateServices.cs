using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Context;
using WebApplication2.Entities;
using WebApplication2.Implementation.Repositories;
using WebApplication2.Interfaces.Repositories;
using WebApplication2.Interfaces.Services;

namespace WebApplication2.Implementation.Services
{
    public class StateServices:IStateServices
    {
        private readonly IStateRepository _stateRepository;

        public StateServices(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }
       
        public bool DeleteState(int id)
        {
            var getState = _stateRepository.GetState(id);
            if (getState == null)
            {
                throw new Exception($"State wth {id} not found");
            }
            _stateRepository.DeleteState(id);
            return true;
        }

        public State GetState(int id)
        {
            var state = _stateRepository.GetState(id);
            if (state == null)
            {
                throw new Exception($"State wth {id} not found"); 
            }
            return _stateRepository.GetState(id);
        }
        
        public State UpdateState(State state, int id)
        {
            var getstate = _stateRepository.GetState(id);
            if (getstate == null)
            {
                throw new Exception($"State wth {id} not found");
            }

            getstate.Name = state.Name;
            getstate.Governor = state.Governor;
            getstate.Population = state.Population;
            getstate.StateIGR = state.StateIGR;
            _stateRepository.UpdateState(getstate);
            return state;
        }
        public IList<State> GetAllState()
        {
            return _stateRepository.GetAllState();
        }

        public IList<State> GetRegionByState(int id)
        {
            return _stateRepository.GetRegionByState(id);
        }

        public bool AddState(State state)
        {
            var newState = new State()
            {
                Name = state.Name, Governor = state.Governor, Population = state.Population, StateIGR = state.StateIGR, RegionId = state.RegionId
            };
            return _stateRepository.AddState(newState);
            
        }
    }
}