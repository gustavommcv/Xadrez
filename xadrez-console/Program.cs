using tabuleiro;
using xadrez_console;
using xadrez;

try {
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.Terminada) {
        try {
            Console.Clear();
            Tela.imprimirPartida(partida);
           
            Console.WriteLine();
            Console.Write("Origem: ");
            Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();
            partida.ValidarPosicaoDeOrigem(origem);

            bool[,] posicoesPossiveis = partida.Tabuleiro.Peca(origem).MovimentosPossiveis();

            Console.Clear();
            Tela.imprimirTabuleiro(partida.Tabuleiro, posicoesPossiveis);

            Console.WriteLine();
            Console.Write("Destino: ");
            Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();
            partida.ValidarPosicaoDeDestino(origem, destino);

            partida.RealizaJogada(origem, destino);
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }
    }

    Tela.imprimirTabuleiro(partida.Tabuleiro);
}
catch (TabuleiroException e) {
    Console.WriteLine(e.Message);
}
