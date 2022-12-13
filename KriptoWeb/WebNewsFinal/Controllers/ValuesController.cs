using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNewsFinal.Models;
using System.Net.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebNewsFinal.Controllers
{
    [Route("api/haberler")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private DataContext context;
        public ValuesController(DataContext ctx)
        {
            context = ctx;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IAsyncEnumerable<Haber> HaberleriCek()
        {
            return context.Haberler;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> HaberiCek(long id)
        {

            Haber haber = await context.Haberler.FindAsync(id);
            if (haber == null)
            {
                return NotFound();
            }
            return Ok(new
            {
                HaberId = haber.HaberId,
                icerik = haber.icerik,
                UserId = haber.KullaniciId,
                KategoriId = haber.KategoriId,
                baslik = haber.baslik,
                kapak_foto = haber.kapak_foto
            });

        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
