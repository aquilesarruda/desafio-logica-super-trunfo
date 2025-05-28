using DesafioLogicaSuperTrunfo.Models;

namespace DesafioLogicaSuperTrunfo.Utils
{
    public static class BaralhoUtils
    {
        public static List<Carta> GerarCartas()
        {
            return new List<Carta>
            {
                new Carta("Leão", 90, 60, 70),
                new Carta("Tigre", 85, 65, 75),
                new Carta("Elefante", 95, 50, 40),
                new Carta("Guepardo", 70, 60, 95)
            };
        }

        public static Carta SortearCarta(List<Carta> cartas)
        {
            Random random = new();
            return cartas[random.Next(cartas.Count)];
        }
    }
}
