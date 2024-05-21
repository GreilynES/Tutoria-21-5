using Entidades;

namespace Services.Clinica
{
    public interface ISvClinica
    {

        public List<Clinic> GetAllClinica();
        public Clinic GetClinicaById(int id);

        //WRITES
        public Clinic AddClinica(Clinic clinica);
        public Clinic UpdateClinica(int id, Clinic author);
        public void DeleteClinica(int id);
    }
}
