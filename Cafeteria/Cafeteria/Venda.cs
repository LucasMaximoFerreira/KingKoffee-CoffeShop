using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Venda
    {
        int id_vda ,id_pagto, id_func;
        double valor_vda, desct_vda;
        DateTime data_vda;
        String prod, Nome_cli;

        public int Id_vda { get => id_vda; set => id_vda = value; }
        public int Id_pagto { get => id_pagto; set => id_pagto = value; }
        public int Id_func { get => id_func; set => id_func = value; }
        public double Valor_vda { get => valor_vda; set => valor_vda = value; }
        public double Desct_vda { get => desct_vda; set => desct_vda = value; }
        public DateTime Data_vda { get => data_vda; set => data_vda = value; }
        public string Prod { get => prod; set => prod = value; }
        public string Nome_cli1 { get => Nome_cli; set => Nome_cli = value; }
    }
}
