﻿using xadrez_console.TabuleiroN;
using xadrez_console.xadrez;

namespace xadrez_console.xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tabuleiro {get ; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaDeXadrez ()
        {
            Tabuleiro = new Tabuleiro(8,8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tabuleiro.retirarPeca(origem);
            p.incrementarQntdMovimentos();
            Peca pecaCapturada = Tabuleiro.retirarPeca(destino);
            Tabuleiro.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            Tabuleiro.colocarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('c', 1).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('c', 2).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('d', 2).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('e', 2).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('e', 1).toPosicao());
            Tabuleiro.colocarPeca(new Rei(Tabuleiro, Cor.Branca), new PosicaoXadrez('d', 1).toPosicao());

            Tabuleiro.colocarPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('c', 7).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('c', 8).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('d',7).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('e', 7).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('e', 8).toPosicao());
            Tabuleiro.colocarPeca(new Rei(Tabuleiro, Cor.Preta), new PosicaoXadrez('d', 8).toPosicao());
        }
    }
}
