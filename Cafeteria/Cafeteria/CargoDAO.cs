using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace Cafeteria
{
    class CargoDAO
    {
        Cargo cargo = new Cargo();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;


        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }
        public void inserir(Cargo cargo)
        {
            executarComando("insert into cargos values(0, '" + cargo.Tipo_cargo + "'");
        }
        public Boolean pesquisarCargo(String id_cargo)
        {
            try
            {
                executarComando("SELECT * FROM cargos WHERE id_cargo='" + id_cargo + "'");
                cargo.Id_cargo = Convert.ToInt32(tabela_memoria.Rows[0]["Id_cargo"].ToString());
                cargo.Tipo_cargo = tabela_memoria.Rows[0]["Tipo_cargo"].ToString();

                return true;
            }
            catch
            {
                return false;
            }
        }
            public DataTable listarTudo()
        {
            executarComando("select * from cargos;");
            return tabela_memoria;
        }
    }
}
