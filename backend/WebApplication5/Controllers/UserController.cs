using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

using WebApplication5.Model;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private WebsitePhongTroContext db = new WebsitePhongTroContext();
        // API PHONG TRO =====================================================================================================================
        [HttpGet]
        public IActionResult getUser()
        {
            try
            {
                return Ok(db.Users.ToList());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("{MaUser}")]
        public IActionResult getUser(int MaUser)
        {
            try
            {
                User a = db.Users.Find(MaUser);
                if (a == null) return NotFound();
                else return Ok(a);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult deleteUser(int id)
        {
            try
            {
                User a = db.Users.Find(id);
                if (a == null) return NotFound();
                else
                {
                    db.Users.Remove(a);
                    db.SaveChanges();
                    return Ok();
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IActionResult postUSer(User h)
        {
            try
            {
                db.Users.Add(h);
                db.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public IActionResult putUser(User h)
        {
            try
            {
                User x = db.Users.Find(h.Mauser);
                if (x == null)
                    return NotFound();
                x.Tenuser = h.Tenuser;
                x.Password = h.Password;
                x.Sodienthoai = h.Sodienthoai;
                x.Email = h.Email;
                x.Anhdaidien = h.Anhdaidien;
                x.Diachiuser = h.Diachiuser;
                db.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}