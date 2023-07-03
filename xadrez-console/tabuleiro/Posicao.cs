using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro { // Novo namespace
    internal class Posicao {

        public int Linha { get; private set; }
        public int Coluna { get; private set; }

        public Posicao(int linha, int coluna) {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString() {
            return Linha + ", " + Coluna;
        }
    }
}
