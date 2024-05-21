using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entidades;
using Services.Usuario;
using Services.ExpedientesMedico;

namespace ApiClinica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private ISvUsuario _svUsuario;
        public UsuarioController(ISvUsuario svUsuario)
        {
            _svUsuario = svUsuario;
        }

        // GET: api/<AuthorsController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _svUsuario.GetAllUsuario();
        }

        // GET api/<AuthorsController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _svUsuario.GetUsuarioById(id);
        }

        // POST api/<AuthorsController>
        [HttpPost]
        public void Post([FromBody] User user)
        {
            _svUsuario.AddUsuario(new User
            {
                NombreUsuario=user.NombreUsuario,
                Contrasenia=user.Contrasenia
            });
        }

        // PUT api/<AuthorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            _svUsuario.UpdateUsuario(id, new User
            {
                NombreUsuario=user.NombreUsuario,
                Contrasenia=user.Contrasenia
            });
        }

        // DELETE api/<AuthorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _svUsuario.DeleteUsuario(id);
        }
    }
}
