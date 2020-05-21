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

        internal Job Create(Job newJob)
        {
            string sql = @"
            INSERT INTO jobs
            (userId, title, salary, hoursweek, citystate, body)
            VALUES
            (@UserId, @Title, @Salary, @HoursWeek, @CityState, @Body);
            SELECT LAST_INSERT_ID()";
            newJob.Id = _db.ExecuteScalar<int>(sql, newJob);
            return newJob;
        }
    }
}