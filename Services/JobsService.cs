using System;
using System.Collections.Generic;
using fullstack_gregslist.Models;
using fullstack_gregslist.Repositories;

namespace fullstack_gregslist.Services
{
    public class JobsService
    {
        private readonly JobsRepository _repo;

        public JobsService(JobsRepository repo)
        {
            _repo = repo;
        }

        internal IEnumerable<Job> GetAll()
        {
            return _repo.GetAll();
        }

        internal Job Create(Job newJob)
        {
            return _repo.Create(newJob);
        }
    }
}