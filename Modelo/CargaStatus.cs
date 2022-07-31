namespace Looking42.Modelo
{
    public class CargaStatus
    {
        public int Id { get; set; }
        public int IdCarga { get; set; }
        public int IdStatus { get; set; }
        public DateTime Horario { get; set; }

        public CargaStatus(int id, int idCarga, int idStatus, DateTime horario)
        {
            Id = id;
            IdCarga = idCarga;
            IdStatus = idStatus;
            Horario = horario;
        }
    }
}
