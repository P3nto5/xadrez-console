﻿

using tabuleiro;

namespace xadrez_console.tabuleiro
{
    class Peca
    {
        public Posicao  Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            Posicao = posicao;
            Cor = cor;
            QteMovimentos = 0;
            Tab = tab;
        }
    }
}