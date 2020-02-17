using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestDivisa.Data;
using ApiRestDivisa.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiRestDivisa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisaController : ControllerBase
    {
        private readonly DivisaContext _context;
        private readonly IDataRepository<Cambio> _repo;

        public DivisaController(DivisaContext context, IDataRepository<Cambio> repo)
        {
            _context = context;
            _repo = repo;
        }

        [HttpGet]
        public string Hello()
        {
            return "Hello World";
        }

        [HttpPost]
        public Cambio Convertir([FromBody] Cambio cambio)
        {
            var output = new Cambio();
            if (ModelState.IsValid)
            {
                var lst = _context.Cambio.ToList();
                var obj = lst.Where(x => x.Tipo == cambio.Tipo).FirstOrDefault();
                if (obj != null)
                {
                    output = obj;
                    output.Total = (cambio.Monto * output.Tasa);
                }
            }

            return output;

        }
    }
}