using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Entrega
    {
        int id_entre, numero_entre;
        string complemento_entre, rua_entre, cidade_entre, estado_entre, bairro_entre, cep_entre;

        public int Id_entre { get => id_entre; set => id_entre = value; }
        public int Numero_entre { get => numero_entre; set => numero_entre = value; }
        public string Complemento_entre { get => complemento_entre; set => complemento_entre = value; }
        public string Rua_entre { get => rua_entre; set => rua_entre = value; }
        public string Cidade_entre { get => cidade_entre; set => cidade_entre = value; }
        public string Estado_entre { get => estado_entre; set => estado_entre = value; }
        public string Bairro_entre { get => bairro_entre; set => bairro_entre = value; }
        public string Cep_entre { get => cep_entre; set => cep_entre = value; }
    }
}
