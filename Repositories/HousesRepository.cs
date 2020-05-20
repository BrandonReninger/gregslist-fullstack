using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using fullstack_gregslist.Models;

namespace fullstack_gregslist.Repositories
{
    public class HousesRepository
    {
        public HousesRepository(IDbConnection db)
        {
            _db = db;
        }
    }
}