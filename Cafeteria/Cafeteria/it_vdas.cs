using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class it_vdas
    {
        int id_it, id_vda, id_prod, qtd_it;
        double subTot_it;

        public int Id_vda { get => id_vda; set => id_vda = value; }
        public int Id_prod { get => id_prod; set => id_prod = value; }
        public int Qtd_it { get => qtd_it; set => qtd_it = value; }
        public double SubTot_it { get => subTot_it; set => subTot_it = value; }
        public int Id_it { get => id_it; set => id_it = value; }
    }
}
