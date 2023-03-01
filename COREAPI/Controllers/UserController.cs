using CORE.Model.Model;
using CORE.Service.IService;
using COREAPI.DATA;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CORE.Api.Controllers
{
    [Route("User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _user;
        public UserController(IUserService user)
        {
            _user = user;
        }

        [HttpPost("AddNew")]
        public async Task<IActionResult> AddUSer([FromBody] User user)
        {
            await _user.Add(user);
            return Ok();
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetUser()
        {
            var users = await _user.GetAll();
            return Ok(users);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _user.Details(id);
            return Ok(user);
        }

        [HttpDelete("DeleteById/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _user.Delete(id);
            return Ok();
        }

        [HttpPut("UpdateById/{id}")]
        public async Task<IActionResult> UpdateUser(int id, User user)
        {
            await _user.Update(id, user);
            return Ok();
        }


        [HttpGet("SearchByName/{name}")]
        public IActionResult SearchByName(String name)
        {
            var users = _user.SearchByName(name);
            return Ok(users);
        }
    }
}
