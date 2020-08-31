using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Cargo
    {
        int id_cargo;
        string tipo_cargo;

        public int Id_cargo { get => id_cargo; set => id_cargo = value; }
        public string Tipo_cargo { get => tipo_cargo; set => tipo_cargo = value; }
    }
}
