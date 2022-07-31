namespace Looking42.Modelo
{
    public class Carga
    {
        public int IdEmpresa { get; set; }
        public string CnpjEmpresa { get; set; }
        public string NomeEmpresa { get; set; }
        public int IdCarga { get; set; }
        public string NomeCarga { get; set; }
        public string DescricaoCarga { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string Status { get; set; }
        public int IdStatus { get; set; }

        //public int Id { get; set; }
        //public string Nome { get; set; }

        //public string Descricao { get; set; }

        //public string Destino { get; set; }

        //public bool Flag { get; set; }

        //public string IdEmpresa { get; set; }

        //public CargaStatus StatusCarga { get; set; }

        //public Carga(int id, string nome, string descricao, string destino, bool flag, string idEmpresa, CargaStatus statusCarga)
        //{
        //    Id = id;
        //    Nome = nome;
        //    Descricao = descricao;
        //    Destino = destino;
        //    Flag = flag;
        //    IdEmpresa = idEmpresa;
        //    StatusCarga = statusCarga;
        //}
    }
}
