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
    }
}