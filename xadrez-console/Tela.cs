﻿using tabuleiro;
using xadrez;

namespace xadrez_console {
    internal class Tela {

        public static void imprimirTabuleiro(Tabuleiro tabuleiro) {
            for (int i = 0; i < tabuleiro.Linhas; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.Colunas; j++) {
                    if (tabuleiro.Peca(i, j) == null) {
                        Console.Write("- ");
                    } else {
                        imprimirPeca(tabuleiro.Peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirPeca(Peca peca) {
            if (peca.Cor == Cor.Branca) {
                Console.Write(peca);
            } else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

        public static PosicaoXadrez lerPosicaoXadrez() {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
    }
}
