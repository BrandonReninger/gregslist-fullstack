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

    public class JobsController : ControllerBase
    {
        private readonly JobsService _js;

        public JobsController(JobsService js)
        {
            _js = js;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Job>> GetAll()
        {
            try
            {
                return Ok(_js.GetAll());
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult<Job> Create([FromBody] Job newJob)
        {
            try
            {
                Claim user = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
                if (user == null)
                {
                    throw new Exception("Login to do that!");
                }
                newJob.UserId = user.Value;
                return Ok(_js.Create(newJob));
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}