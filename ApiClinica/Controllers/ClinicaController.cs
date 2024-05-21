using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entidades;
using Services.Clinica;

namespace ApiClinica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicaController : Controller
    {
        private ISvClinica _svClinica;
        public ClinicaController(ISvClinica svClinica)
        {
            _svClinica = svClinica;
        }

        // GET: api/<AuthorsController>
        [HttpGet]
        public IEnumerable<Clinic> Get()
        {
            return _svClinica.GetAllClinica();
        }

        // GET api/<AuthorsController>/5
        [HttpGet("{id}")]
        public Clinic Get(int id)
        {
            return _svClinica.GetClinicaById(id);
        }

        // POST api/<AuthorsController>
        [HttpPost]
        public void Post([FromBody] Clinic clinic)
        {
            _svClinica.AddClinica(new Clinic
            {
                Name = clinic.Name,
            });
        }

        // PUT api/<AuthorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Clinic clinic)
        {
            _svClinica.UpdateClinica(id, new Clinic
            {
                Name = clinic.Name,
            });
        }

        // DELETE api/<AuthorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _svClinica.DeleteClinica(id);
        }
    }
}
