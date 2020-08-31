using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class tipo_prod
    {
        int id_tipo, qtdEst_tipo;
        string nome_tipo;

        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public int QtdEst_tipo { get => qtdEst_tipo; set => qtdEst_tipo = value; }
        public string Nome_tipo { get => nome_tipo; set => nome_tipo = value; }
    }
}
