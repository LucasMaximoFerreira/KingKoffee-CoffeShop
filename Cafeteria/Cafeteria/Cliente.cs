using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    class Cliente
    {

        int id_cli;
        String usuario_cli, senha_cli, cpf_cli, tel_cli, cid_cli, email_cli;

        public int Id_cli { get => id_cli; set => id_cli = value; }
        public string Usuario_cli { get => usuario_cli; set => usuario_cli = value; }
        public string Senha_cli { get => senha_cli; set => senha_cli = value; }
        public string Cpf_cli { get => cpf_cli; set => cpf_cli = value; }
        public string Tel_cli { get => tel_cli; set => tel_cli = value; }
        public string Cid_cli { get => cid_cli; set => cid_cli = value; }
        public string Email_cli { get => email_cli; set => email_cli = value; }
    }
}
