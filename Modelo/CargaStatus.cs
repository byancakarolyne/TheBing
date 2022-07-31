namespace Looking42.Modelo
{
    public class CargaStatus
    {
        public int IdCargaSatus { get; set; }
        public int IdCarga { get; set; }
        public int IdStatus { get; set; }

        //public string Nome { get; set; }
        //public int Id { get; set; }
        public DateTime Horario { get; set; }

        //public CargaStatus(int id, int idCarga, int idStatus, DateTime horario)
        //{
        //    Id = id;
        //    IdCarga = idCarga;
        //    IdStatus = idStatus;
        //    Horario = horario;
        //}
    }
}
