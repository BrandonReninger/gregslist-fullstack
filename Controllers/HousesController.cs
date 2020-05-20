using System;
using System.Collections.Generic;
using System.Security.Claims;
using fullstack_gregslist.Models;
using fullstack_gregslist.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fullstack_gregslist.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        private readonly HousesService _hs;

        public HousesController(HousesService hs)
        {
            _hs = hs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<House>> GetAll()
        {

        }
    }
}