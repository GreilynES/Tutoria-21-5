
using Entidades;

namespace Services.ExpedientesMedico
{
    public interface ISvExpedienteMedico
    {
        
        public List<MedicalRecord> GetAllExpedienteMedico();
        
        public MedicalRecord AddExpedienteMedico(MedicalRecord medicalRecord);
        public MedicalRecord UpdateExpedienteMedico(int id, MedicalRecord medicalRecord);

        public MedicalRecord GetExpedienteMedicoById(int id);

        public List<MedicalRecord> AddUsuarios(List<MedicalRecord> medicalRecords);
        public void DeleteExpedienteMedico(int id);
    }
}
