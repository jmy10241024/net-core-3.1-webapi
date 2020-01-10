using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCore.Bo.UserInfo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XCode.Membership;

namespace ApiCore.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class UserController : ControllerBase
    {
        readonly UserRepositofy repo = new UserRepositofy();
        [HttpGet]
        public async Task<IActionResult>  UserAdd() => Ok(await repo.UserAdd());
        [HttpGet]
        public async Task<IActionResult>  UserSearch() => Ok(await repo.UserSearch());
     



    }
}