namespace Looking42.Modelo
{
    public class Transportadora
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Destino { get; set; }

        public Transportadora (int id, string nome, string destino)
        {
            Id = id;
            Nome = nome;
            Destino = destino;
        }
    }
}
