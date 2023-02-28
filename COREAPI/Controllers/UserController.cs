//using CORE.Model.Model;
//using CORE.Service.IService;
//using COREAPI.DATA;
//using Microsoft.AspNetCore.Mvc;
//using System;

//namespace CORE.Api.Controllers
//{
//    [Route("User")]
//    [ApiController]
//    public class UserController : ControllerBase
//    {
//        private readonly IUserService _user;
//        public UserController(IUserService user)
//        {
//            _user = user;
//        }

//        [HttpPost("AddNew")]
//        public IActionResult AddUSer([FromBody] User user)
//        {
//            _user.Add(user);
//            return Ok();
//        }

//        [HttpGet("GetAll")]
//        public IActionResult GetUser()
//        {
//            var users = _user.GetAll();
//            return Ok(users);
//        }

//        [HttpGet("GetById/{id}")]
//        public IActionResult GetUser(int id)
//        {
//            var user = _user.Details(id);
//            return Ok(user);
//        }

//        [HttpPut("UpdateById/{id}")]
//        public IActionResult UpdateUser(int id, User user)
//        {
//            _user.Update(id, user);
//            return Ok();
//        }

//        [HttpDelete("DeleteById/{id}")]
//        public IActionResult DeleteUser(int id)
//        {
//            _user.Delete(id);
//            return Ok();
//        }
//        [HttpGet("SearchByName/{name}")]
//        public IActionResult SearchByName(String name)
//        {
//            var users = _user.SearchByName(name);
//            return Ok(users);
//        }
//    }
//}
