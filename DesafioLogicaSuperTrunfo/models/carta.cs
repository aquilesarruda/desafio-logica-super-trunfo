namespace DesafioLogicaSuperTrunfo.Models
{
    public class Carta
    {
        public string Nome { get; set; }
        public int Forca { get; set; }
        public int Inteligencia { get; set; }
        public int Velocidade { get; set; }

        public Carta(string nome, int forca, int inteligencia, int velocidade)
        {
            Nome = nome;
            Forca = forca;
            Inteligencia = inteligencia;
            Velocidade = velocidade;
        }

        public int ObterValorDoAtributo(string atributo)
        {
            return atributo.ToLower() switch
            {
                "forca" => Forca,
                "inteligencia" => Inteligencia,
                "velocidade" => Velocidade,
                _ => throw new ArgumentException("Atributo inválido")
            };
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nForça: {Forca}, Inteligência: {Inteligencia}, Velocidade: {Velocidade}";
        }
    }
}
