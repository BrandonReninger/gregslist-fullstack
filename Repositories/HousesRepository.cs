using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using fullstack_gregslist.Models;

namespace fullstack_gregslist.Repositories
{
    public class HousesRepository
    {
        private readonly IDbConnection _db;

        public HousesRepository(IDbConnection db)
        {
            _db = db;
        }

        internal IEnumerable<House> GetAll()
        {
            string sql = "SELECT * FROM houses";
            return _db.Query<House>(sql);
        }

        internal House Create(House newHouse)
        {
            string sql = @"
            INSERT INTO houses
            (userId, bedrooms, bathrooms, levels, year, price, imgUrl, body)
            VALUE
            (@UserId, @Bedrooms, @Bathrooms, @Levels, @Year, @Price, @ImgUrl, @Body);
            SELECT LAST_INSERT_ID()";
            newHouse.Id = _db.ExecuteScalar<int>(sql, newHouse);
            return newHouse;
        }
    }
}