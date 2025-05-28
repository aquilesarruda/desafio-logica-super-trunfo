using DesafioLogicaSuperTrunfo.Models;
using DesafioLogicaSuperTrunfo.Utils;

namespace DesafioLogicaSuperTrunfo.Services
{
    public class JogoService
    {
        public void Iniciar()
        {
            var baralho = BaralhoUtils.GerarCartas();

            bool continuar = true;
            while (continuar)
            {
                var cartaJogador = BaralhoUtils.SortearCarta(baralho);
                var cartaComputador = BaralhoUtils.SortearCarta(baralho);

                Console.WriteLine("Sua carta:");
                Console.WriteLine(cartaJogador);

                Console.Write("\nEscolha um atributo (forca, inteligencia, velocidade): ");
                string atributo = Console.ReadLine()!.ToLower();

                int valorJogador = cartaJogador.ObterValorDoAtributo(atributo);
                int valorComputador = cartaComputador.ObterValorDoAtributo(atributo);

                Console.WriteLine($"\nCarta do computador:");
                Console.WriteLine(cartaComputador);

                if (valorJogador > valorComputador)
                    Console.WriteLine("\n🎉 Você venceu!");
                else if (valorJogador < valorComputador)
                    Console.WriteLine("\n😞 Você perdeu!");
                else
                    Console.WriteLine("\n⚖️ Empate!");

                Console.Write("\nDeseja jogar novamente? (s/n): ");
                continuar = Console.ReadLine()!.ToLower() == "s";
                Console.Clear();
            }
        }
    }
}
