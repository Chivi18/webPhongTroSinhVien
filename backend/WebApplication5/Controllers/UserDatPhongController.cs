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
    public class UserDatPhongController : ControllerBase
    {
        private WebsitePhongTroContext db = new WebsitePhongTroContext();
        // API PHONG TRO =====================================================================================================================
        [HttpGet]
        public IActionResult getUserDatPhong()
        {
            try
            {
                return Ok(db.Userdatphongs.ToList());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("{MaPhong}")]
        public IActionResult getUserDatPhong(int MaPhong)
        {
            try
            {
                Userdatphong a = db.Userdatphongs.Find(MaPhong);
                if (a == null) return NotFound();
                else return Ok(a);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult deleteUserDatPhong(int id)
        {
            try
            {
                Userdatphong a = db.Userdatphongs.Find(id);
                if (a == null) return NotFound();
                else
                {
                    db.Userdatphongs.Remove(a);
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
        public IActionResult postUserDatPhong(Userdatphong h)
        {
            try
            {
                db.Userdatphongs.Add(h);
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