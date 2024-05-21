using Entidades;
using Microsoft.EntityFrameworkCore;
using Services.MyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Usuario
{
    public class SvUsuario : ISvUsuario
    {
        private MyContext _myDbContext = default!;
        public SvUsuario()
        {
            _myDbContext = new MyContext();
        }

        public User AddUsuario(User user)
        {
            _myDbContext.Users.Add(user);
            _myDbContext.SaveChanges();

            return user;
        }

        public List<User> AddUsuarios(List<User> users)
        {
            return _myDbContext.Users.Include(x => x.MedicalRecord).ToList();
        }

        public void DeleteUsuario(int id)
        {
            User deleteUser = _myDbContext.Users.Find(id);

            if (deleteUser is not null)
            {
                _myDbContext.Users.Remove(deleteUser);
                _myDbContext.SaveChanges();
            }
        }

        public List<User> GetAllUsuario()
        {
            return _myDbContext.Users.Include(x => x.MedicalRecord).ToList();
        }

        public User GetUsuarioById(int id)
        {
            return _myDbContext.Users.Include(x => x.MedicalRecord).SingleOrDefault(x => x.Id == id);
        }

        public User UpdateUsuario(int id, User newusuario)
        {
            User updateUser = _myDbContext.Users.Find(id);

            if (updateUser is not null)
            {
                updateUser.NombreUsuario = newusuario.NombreUsuario;
                updateUser.Contrasenia = newusuario.Contrasenia;

                _myDbContext.Users.Update(updateUser);
                _myDbContext.SaveChanges();
            }

            return updateUser;
        }
    }
}
