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
    class ProdutosDAO
    {
        Cliente cli = new Cliente();

        Produto prod = new Produto();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        internal Produto Prod { get => prod; set => prod = value; }
        internal Cliente Cli { get => cli; set => cli = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }
        public void inserir(Produto prodd)
        {
            executarComando("insert into produtos values(0, '"+prodd.Id_tipo+"','"+prodd.Nome_prod+"','"+prodd.Compl_prod+ "','" + prodd.Qtd_prod + "','" + prodd.Valor_prod.ToString().Replace(',','.')+"');");


        }
        public Boolean pesquisaProd(String id_prod)
        {
            try
            {
                executarComando("select id_prod, id_tipo, nome_prod, compl_prod, qtd_prod, valor_prod from produtos where id_prod = '"+id_prod+"'");

                prod.Id_prod = Convert.ToInt32(tabela_memoria.Rows[0]["Id_prod"].ToString());
                prod.Id_tipo = Convert.ToInt32(tabela_memoria.Rows[0]["Id_tipo"].ToString());
                prod.Nome_prod = tabela_memoria.Rows[0]["Nome_prod"].ToString();
                prod.Compl_prod = tabela_memoria.Rows[0]["Compl_prod"].ToString();
                prod.Qtd_prod = Convert.ToInt32(tabela_memoria.Rows[0]["Qtd_prod"].ToString());
                prod.Valor_prod = Convert.ToDouble(tabela_memoria.Rows[0]["Valor_prod"].ToString());

                return true;
            }
            catch
            {
                return false;
            }
        }
        public int Prd()
        {
            Compra.UltProd1 = Convert.ToInt32(tabela_memoria.Rows[0]["id_prod"].ToString());
            return Compra.UltProd1;
        }
        public DataTable ListarProduto()
        {
            executarComando("select * from produtos;");
            return tabela_memoria;
        }
       
        public void excluir()
        {
            executarComando("delete from produtos;");
        }
       
    }
}
