using Entidades;
using Microsoft.EntityFrameworkCore;
using Services.MyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Clinica
{
    public class SvClinica : ISvClinica
    {
        private MyContext _myDbContext = default!;
        public SvClinica()
        {
            _myDbContext = new MyContext();
        }

        public Clinic AddClinica(Clinic clinica)
        {
            _myDbContext.Clinics.Add(clinica);
            _myDbContext.SaveChanges();

            return clinica;
        }

        public void DeleteClinica(int id)
        {
            Clinic deleteClinic = _myDbContext.Clinics.Find(id);

            if (deleteClinic is not null)
            {
                _myDbContext.Clinics.Remove(deleteClinic);
                _myDbContext.SaveChanges();
            }
        }

        public List<Clinic> GetAllClinica()
        {
            return _myDbContext.Clinics.Include(x => x.Users).ToList();
        }

        public Clinic GetClinicaById(int id)
        {
            return _myDbContext.Clinics.Include(x => x.Users).SingleOrDefault(x => x.Id == id);
        }

        public Clinic UpdateClinica(int id, Clinic newClinic)
        {
            Clinic updateClinic = _myDbContext.Clinics.Find(id);

            if (updateClinic is not null)
            {
                updateClinic.Name = newClinic.Name;

                _myDbContext.Clinics.Update(updateClinic);
                _myDbContext.SaveChanges();
            }

            return updateClinic;

        }
    }
}
