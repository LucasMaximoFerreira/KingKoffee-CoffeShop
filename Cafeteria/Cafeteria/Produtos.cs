﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Produtos
    {
        int id_prod, id_forn, id_tipo, qtd_prod;
        String nome_prod, compl_prod;
        double valor_prod;

        public int Id_prod { get => id_prod; set => id_prod = value; }
        public int Id_forn { get => id_forn; set => id_forn = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public int Qtd_prod { get => qtd_prod; set => qtd_prod = value; }
        public string Nome_prod { get => nome_prod; set => nome_prod = value; }
        public string Compl_prod { get => compl_prod; set => compl_prod = value; }
        public double Valor_prod { get => valor_prod; set => valor_prod = value; }
    }
}
