using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using fullstack_gregslist.Models;

namespace fullstack_gregslist.Repositories
{
    public class JobsRepository
    {
        private readonly IDbConnection _db;

        public JobsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal IEnumerable<Job> GetAll()
        {
            string sql = "SELECT * FROM jobs";
            return _db.Query<Job>(sql);
        }
    }
}