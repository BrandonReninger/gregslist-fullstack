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
    }
}