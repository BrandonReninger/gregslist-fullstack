using System;
using System.Collections.Generic;
using fullstack_gregslist.Models;
using fullstack_gregslist.Repositories;

namespace fullstack_gregslist.Services
{
    public class HousesService
    {
        private readonly HousesRepository _repo;

        public HousesService(HousesRepository repo)
        {
            _repo = repo;
        }

        internal IEnumerable<House> GetAll()
        {
            return _repo.GetAll();
        }

        internal House Create(House newHouse)
        {
            return _repo.Create(newHouse);
        }

        internal House GetById(int id)
        {
            House foundHouse = _repo.GetById(id);
            if (foundHouse == null)
            {
                throw new Exception("invalid id!!");
            }
            return foundHouse;
        }

        internal string Delete(int id, string userId)
        {
            House foundHouse = GetById(id);
            if (foundHouse.UserId != userId)
            {
                throw new Exception("Not your house bud!");
            }
            if (_repo.Delete(id, userId))
            {
                return "Deleted Successfully";
            }
            throw new Exception("Mistakes were made");
        }
    }
}