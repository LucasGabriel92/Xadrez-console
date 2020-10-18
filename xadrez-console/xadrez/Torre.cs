using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, CorPeca cor) : base(cor, tab) { }

        public override string ToString()
        {
            return "T";
        }
    }
}
