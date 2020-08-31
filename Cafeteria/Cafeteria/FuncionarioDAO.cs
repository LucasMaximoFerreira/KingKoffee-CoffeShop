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
    class FuncionarioDAO
    {
        Funcionario func = new Funcionario();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        internal Funcionario Func { get => func; set => func = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }
        public Boolean verificarFuncionario(Funcionario func)
        {
            try
            {
                executarComando("select * from funcionarios where nome_func = '" + func.Nome_func + "' and senha_func = '" + func.Senha_func + "'");

                func.Nome_func = tabela_memoria.Rows[0]["Nome_func"].ToString();
                func.Senha_func = tabela_memoria.Rows[0]["Senha_func"].ToString();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean pesquisarFuncionario(String id_func)
        {
            try
            {
                executarComando("SELECT * FROM funcionarios WHERE id_func='" + id_func + "'");
                func.Id_func = Convert.ToInt32(tabela_memoria.Rows[0]["Id_func"].ToString());
                func.Id_cargo = Convert.ToInt32(tabela_memoria.Rows[0]["Id_cargo"].ToString());
                func.Nome_func = tabela_memoria.Rows[0]["Nome_func"].ToString();
                func.Senha_func = tabela_memoria.Rows[0]["Senha_func"].ToString();
                func.Tel_func = tabela_memoria.Rows[0]["Tel_func"].ToString();
                func.Sal_func = Convert.ToDouble(tabela_memoria.Rows[0]["Sal_func"].ToString());
                func.Email_func = tabela_memoria.Rows[0]["Email_func"].ToString();
                func.Sx_func = tabela_memoria.Rows[0]["Sx_func"].ToString();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public void inserir(Funcionario func)
        {
            executarComando("insert into funcionarios values(0, '" + func.Id_cargo + "', '" + func.Nome_func + "', '" + func.Senha_func + "', '" + func.Tel_func + "', '" + func.Sal_func + "', '" + func.Email_func + "', '" + func.Sx_func + "'); ");
        }
        public DataTable listarTudo()
        {
            executarComando("select * from funcionarios;");
            return tabela_memoria;
        }
       
    }
}
