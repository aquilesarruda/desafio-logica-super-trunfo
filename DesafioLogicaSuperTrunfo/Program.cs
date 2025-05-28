using DesafioLogicaSuperTrunfo.Services;

class Program
{
    static void Main()
    {
        var jogo = new JogoService();
        jogo.Iniciar();
    }
}
