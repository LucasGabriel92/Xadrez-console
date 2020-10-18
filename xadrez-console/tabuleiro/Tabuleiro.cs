using System;
using System.Collections.Generic;
using System.Text;

namespace xadrez_console.tabuleiro
{
    class Tabuleiro
    {

        public int NumLinhas { get; set; }
        public int NumColunas { get; set; }
        private Peca[,] Pecas { get; set; }

        public Tabuleiro(int numLinhas, int numColunas)
        {
            NumLinhas = numLinhas;
            NumColunas = numColunas;
            Pecas = new Peca[numLinhas, numColunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
    }
}
