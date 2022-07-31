namespace Looking42.Modelo
{
    public class TipoCarga
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public TipoCarga(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
