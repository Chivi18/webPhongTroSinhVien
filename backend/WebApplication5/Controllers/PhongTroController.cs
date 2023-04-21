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
    public class PhongTroController : ControllerBase
    {
        private WebsitePhongTroContext db = new WebsitePhongTroContext();
        // API PHONG TRO =====================================================================================================================
        [HttpGet]
        public IActionResult getPhongTro()
        {
            try
            {
                return Ok(db.Phongtros.ToList());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("{MaPhong}")]
        public IActionResult getPhongTro(int MaPhong)
        {
            try
            {
                Phongtro a = db.Phongtros.Find(MaPhong);
                if (a == null) return NotFound();
                else return Ok(a);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult deletePhongTro(int id)
        {
            try
            {
                Phongtro a = db.Phongtros.Find(id);
                if (a == null) return NotFound();
                else
                {
                    db.Phongtros.Remove(a);
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
        public IActionResult postPhongTro(Phongtro h)
        {
            try
            {
                db.Phongtros.Add(h);
                db.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public IActionResult putPhongTro(Phongtro h)
        {
            try
            {
                Phongtro x = db.Phongtros.Find(h.Maphong);
                if (x == null)
                    return NotFound();
                x.Hinhanh1 = h.Hinhanh1;
                x.Hinhanh2 = h.Hinhanh2;
                x.Hinhanh3 = h.Hinhanh3;
                x.Gia = h.Gia;
                x.Loai = h.Loai;
                x.Phongngu = h.Phongngu;
                x.Nhatam = h.Nhatam;
                x.Wifi = h.Wifi;
                x.Maylanh = h.Maylanh;
                x.Dientich = h.Dientich;
                x.Diachi = h.Diachi;
                x.Guixe = h.Guixe;
                x.Conphong = h.Conphong;
                x.Mota = h.Mota;
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
