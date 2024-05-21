using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.ExpedientesMedico;

namespace ApiClinica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpedienteMedicoController : Controller
    {
        private ISvExpedienteMedico _svExpediente;
        public ExpedienteMedicoController(ISvExpedienteMedico svExpediente)
        {
            _svExpediente = svExpediente;
        }

        // GET: api/<AuthorsController>
        [HttpGet]
        public IEnumerable<MedicalRecord> Get()
        {
            return _svExpediente.GetAllExpedienteMedico();
        }

        // GET api/<AuthorsController>/5
        [HttpGet("{id}")]
        public MedicalRecord Get(int id)
        {
            return _svExpediente.GetExpedienteMedicoById(id);
        }

        // POST api/<AuthorsController>
        [HttpPost]
        public void Post([FromBody] MedicalRecord medicalRecord)
        {
            _svExpediente.AddExpedienteMedico(new MedicalRecord
            {
                HistorialC = medicalRecord.HistorialC,
                Alergias = medicalRecord.Alergias,
                GrupoSanguineo = medicalRecord.GrupoSanguineo
            });
        }

        // PUT api/<AuthorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MedicalRecord medicalRecord)
        {
            _svExpediente.UpdateExpedienteMedico(id, new MedicalRecord
            {
                HistorialC = medicalRecord.HistorialC,
                Alergias = medicalRecord.Alergias,
                GrupoSanguineo = medicalRecord.GrupoSanguineo
            });
        }

        // DELETE api/<AuthorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _svExpediente.DeleteExpedienteMedico(id);
        }
    }
}
