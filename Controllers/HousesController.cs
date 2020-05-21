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
            try
            {
                return Ok(_hs.GetAll());
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult<House> Create([FromBody] House newHouse)
        {
            try
            {
                Claim user = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
                if (user == null)
                {
                    throw new Exception("login to post new stuff dude!");
                }
                newHouse.UserId = user.Value;
                return Ok(_hs.Create(newHouse));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [Authorize]
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            try
            {
                Claim user = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
                if (user == null)
                {
                    throw new Exception("Login to do that!!");
                }
                string userId = user.Value;
                return Ok(_hs.Delete(id, userId));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}