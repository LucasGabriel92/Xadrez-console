using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, CorPeca cor) : base(cor, tab) { }

        public override string ToString()
        {
            return "R";
        }
    }
}
