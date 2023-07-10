using tabuleiro;
using xadrez_console;
using xadrez;

try {
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.Terminada) {

        Console.Clear();
        Tela.imprimirTabuleiro(partida.Tabuleiro);

        Console.WriteLine();
        Console.Write("Origem: ");
        Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();

        bool[,] posicoesPossiveis = partida.Tabuleiro.Peca(origem).MovimentosPossiveis();
        
        Console.Clear();
        Tela.imprimirTabuleiro(partida.Tabuleiro, posicoesPossiveis);

        Console.WriteLine();
        Console.Write("Destino: ");
        Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();
    
        partida.ExecutaMovimento(origem, destino);
    }

    Tela.imprimirTabuleiro(partida.Tabuleiro);
}
catch (TabuleiroException e) {
    Console.WriteLine(e.Message);
}
