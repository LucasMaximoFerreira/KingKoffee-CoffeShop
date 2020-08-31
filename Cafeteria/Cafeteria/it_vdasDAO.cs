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
    class it_vdasDAO
    {
        ProdutosDAO prodDao = new ProdutosDAO();
        Produto prod = new Produto();
        it_vdas it = new it_vdas();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        internal it_vdas It { get => it; set => it = value; }
        internal Produto Prod { get => prod; set => prod = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);


            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }
        public void inserirItVendas(it_vdas itvdas)
        {
            executarComando("insert into it_vdas values(0, '" + itvdas.Id_prod + "', '" + itvdas.Id_vda + "', '" + itvdas.Qtd_it + "', '" + itvdas.SubTot_it.ToString().Replace(',','.') +"');");


        }
       
        public DataTable ListarTudo()
        {
            executarComando("select * from it_vdas;");  
            return tabela_memoria;
        }
        public Boolean PesquisarItem(String id_it)
        {
            try
            {
                executarComando("select it.id_it, v.id_vda, it.id_prod, it.qtd_it, it.subtot_it from it_vdas it inner join venda v on v.id_vda = it.id_vda where it.id_it = '"+id_it+"';");

                it.Id_it = Convert.ToInt32(tabela_memoria.Rows[0]["Id_it"].ToString());
                it.Id_prod = Convert.ToInt32(tabela_memoria.Rows[0]["Id_prod"].ToString());
                it.Id_vda = Convert.ToInt32(tabela_memoria.Rows[0]["Id_vda"].ToString());
                it.Qtd_it = Convert.ToInt32(tabela_memoria.Rows[0]["Qtd_it"].ToString());
                it.SubTot_it = Convert.ToDouble(tabela_memoria.Rows[0]["SubTot_it"].ToString());

                return true;
            }
            catch
            {
                return false;
            }

        }
       


        public void excluir()
        {
            executarComando("delete from it_vdas;");
        }

    }
}
