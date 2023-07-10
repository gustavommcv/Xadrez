﻿namespace tabuleiro {
    internal abstract class Peca {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Cor cor, Tabuleiro tabuleiro) {
            Posicao = null;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QuantidadeMovimentos = 0;
        }

        public void IncrementarQteMovimentos() {
            QuantidadeMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();

    }
}
