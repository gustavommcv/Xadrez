using System.Text;
using tabuleiro;

namespace xadrez {
    internal class PosicaoXadrez {

        public int Linha { get; set; }
        public char Coluna { get; set; }

        public PosicaoXadrez(char coluna, int linha) {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao() {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.Append(Coluna);
            sb.Append(Linha);

            return sb.ToString();
        }
    }
}
