﻿using System;
using System.Collections.Generic;
using System.Text;

namespace xadrez_console.tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public CorPeca Cor { get; protected set; }
        public int QtdadeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(CorPeca cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QtdadeMovimentos = 0;
        }
    }
}
