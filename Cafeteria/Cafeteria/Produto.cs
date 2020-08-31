using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Produto
    {
        int id_prod, qtd_prod,id_tipo;
        double valor_prod;
        String nome_prod, compl_prod;

        public int Id_prod { get => id_prod; set => id_prod = value; }
        public int Qtd_prod { get => qtd_prod; set => qtd_prod = value; }
        public double Valor_prod { get => valor_prod; set => valor_prod = value; }
        public string Nome_prod { get => nome_prod; set => nome_prod = value; }
        public string Compl_prod { get => compl_prod; set => compl_prod = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
    }
}
