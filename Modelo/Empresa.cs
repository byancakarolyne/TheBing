namespace Looking42.Modelo
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public Carga Cargas { get;set; }

        public Empresa(int id, string nome, string cnpj, Carga cargas)
        {
            Id = id;
            Nome = nome;
            Cnpj = cnpj;
            Cargas = cargas;
        }
    }
}
