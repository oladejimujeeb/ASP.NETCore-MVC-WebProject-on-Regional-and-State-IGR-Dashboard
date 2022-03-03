using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Context;
using WebApplication2.Entities;
using WebApplication2.Interfaces.Repositories;

namespace WebApplication2.Implementation.Repositories
{
    public class StateRepository:IStateRepository
    {
        private readonly ApplicationContext _context;

        public StateRepository(ApplicationContext context)
        {
            _context = context;
        }
        public bool AddState(State state)
        {
             _context.States.Add(state);
             _context.SaveChanges();
             return true;
        }

        public bool DeleteState(int id)
        {
            var state = _context.States.Find(id);
            _context.States.Remove(state);
            _context.SaveChanges();
            return true;
        }

        public State GetState(int id)
        {
            return _context.States.Find(id);
        }

        public bool UpdateState(State state)
        {
            _context.States.Update(state);
            _context.SaveChanges();
            return true;
        }
        public IList<State> GetAllState()
        {
            return _context.States.ToList();
        }

        public IList<State> GetRegionByState(int id)
        {
            var region = _context.States.Include(x=>x.Region).Where(x => x.RegionId == id).ToList();
            return region;
        }

        
    }
}