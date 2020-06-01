using System;


namespace tabuleiro
{
    class Peca
    {
        public Cor Cor { get; protected set; }
        public Posicao Posicao { get; set; }
        public int QtdMovimentos { get; set; }
        public Tabuleiro Tab { get; set; }

        public Peca (Posicao posicao, Tabuleiro tabuleiro, Cor cor)
        {
            Cor = cor;
            Posicao = posicao;
            Tab = tabuleiro;
            QtdMovimentos = 0;
        }

        
    }
}
