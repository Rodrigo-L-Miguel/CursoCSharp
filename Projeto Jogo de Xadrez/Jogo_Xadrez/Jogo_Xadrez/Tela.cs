using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace Jogo_Xadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for(int i = 0; i < tab.Linhas; i++)
            {
                for(int j = 0; j<tab.Colunas; j++)
                {
                    Console.WriteLine(tab.Peca(i,j) + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
