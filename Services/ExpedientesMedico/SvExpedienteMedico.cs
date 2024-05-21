using Entidades;
using Microsoft.EntityFrameworkCore;
using Services.Clinica;
using Services.ExpedientesMedico;
using Services.MyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ExpedienteMedico
{
    internal class SvExpedienteMedico : ISvExpedienteMedico
    {
        private MyContext _myDbContext = default!;
        public SvExpedienteMedico()
        {
            _myDbContext = new MyContext();
        }
        public MedicalRecord AddExpedienteMedico(MedicalRecord medicalRecord)
        {
            _myDbContext.medicalRecords.Add(medicalRecord);
            _myDbContext.SaveChanges();

            return medicalRecord;
        }

        public List<MedicalRecord> AddUsuarios(List<MedicalRecord> medicalRecords)
        {
            return _myDbContext.medicalRecords.Include(x => x.User).ToList();
        }

        public void DeleteExpedienteMedico(int id)
        {
            MedicalRecord deleteExpedienteMedico = _myDbContext.medicalRecords.Find(id);

            if (deleteExpedienteMedico is not null)
            {
                _myDbContext.medicalRecords.Remove(deleteExpedienteMedico);
                _myDbContext.SaveChanges();
            }
        }

        public List<MedicalRecord> GetAllExpedienteMedico()
        {
            return _myDbContext.medicalRecords.Include(x => x.User).ToList();
        }

        public MedicalRecord GetExpedienteMedicoById(int id)
        {
            return _myDbContext.medicalRecords.Include(x => x.User).SingleOrDefault(x => x.Id == id);
        }

        public MedicalRecord UpdateExpedienteMedico(int id, MedicalRecord newmedicalRecord)
        {
            MedicalRecord updatemedicalrecor = _myDbContext.medicalRecords.Find(id);

            if (updatemedicalrecor is not null)
            {
                updatemedicalrecor.HistorialC = newmedicalRecord.HistorialC;
                updatemedicalrecor.Alergias = newmedicalRecord.Alergias;
                updatemedicalrecor.GrupoSanguineo= newmedicalRecord.GrupoSanguineo;

                _myDbContext.medicalRecords.Update(updatemedicalrecor);
                _myDbContext.SaveChanges();
            }

            return updatemedicalrecor;
        }
    }
}
