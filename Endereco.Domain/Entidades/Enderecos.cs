namespace Endereco.Domain.Entidades
{
    public class Enderecos
    {
        public int Cep { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public int? Apartamento { get; set; }
    }
}
