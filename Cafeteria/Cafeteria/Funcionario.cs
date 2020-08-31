using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Funcionario
    {
        String nome_func, senha_func, tel_func, email_func, sx_func;
        int id_func, id_cargo;
        double sal_func;

        public string Nome_func { get => nome_func; set => nome_func = value; }
        public string Senha_func { get => senha_func; set => senha_func = value; }
        public string Tel_func { get => tel_func; set => tel_func = value; }
        public string Email_func { get => email_func; set => email_func = value; }
        public string Sx_func { get => sx_func; set => sx_func = value; }
        public int Id_func { get => id_func; set => id_func = value; }
        public int Id_cargo { get => id_cargo; set => id_cargo = value; }
        public double Sal_func { get => sal_func; set => sal_func = value; }
    }
}
