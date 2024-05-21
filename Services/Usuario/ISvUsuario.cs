using Entidades;

namespace Services.Usuario
{
    public interface ISvUsuario
    {
        public List<User> GetAllUsuario();
        public User AddUsuario(User user);
        public User UpdateUsuario(int id, User usuario);

        public User GetUsuarioById(int id);

        public List<User> AddUsuarios(List<User> users);
        public void DeleteUsuario(int id);
    }
}
