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
    class tipo_prodDAO
    {
        tipo_prod tipo = new tipo_prod();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        internal tipo_prod Tipo { get => tipo; set => tipo = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }
        public void inserir(tipo_prod tipo)
        {
            executarComando("insert into produtos values (0,'" + tipo.Id_tipo + "','" + tipo.Nome_tipo + "','" + tipo.QtdEst_tipo + "')");

          
          
        }
        public Boolean pesquisarTipoProd(String id_tipo)
        {
            try
            {
                executarComando("SELECT * FROM tipo_prod WHERE id_tipo='" + id_tipo + "'");
                tipo.Id_tipo = Convert.ToInt32(tabela_memoria.Rows[0]["Id_tipo"].ToString());
                tipo.Nome_tipo = tabela_memoria.Rows[0]["Nome_tipo"].ToString();
                tipo.QtdEst_tipo = Convert.ToInt32(tabela_memoria.Rows[0]["QtdEst_tipo"].ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable ListarTipo()
        {
            executarComando("select * from Tipo_prod");
            return tabela_memoria;
        }
    }
}
