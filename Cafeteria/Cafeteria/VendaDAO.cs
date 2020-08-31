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
    class VendaDAO
    {
        clienteDAO cliDao = new clienteDAO();
        Cliente cli = new Cliente();
        Produto prod = new Produto();
        it_vdas itvda = new it_vdas();
        Venda venda = new Venda();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        internal Venda Venda { get => venda; set => venda = value; }
        internal it_vdas Itvda { get => itvda; set => itvda = value; }
        internal Produto Prod { get => prod; set => prod = value; }
        internal Cliente Cli { get => cli; set => cli = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }
       
        public void inserir(Venda venda)
        {
            executarComando("insert into venda values(0, '"+venda.Nome_cli1+"', '"+venda.Id_pagto+"', 1, '"+venda.Data_vda.ToString("yyyy/MM/dd")+"', '"+venda.Valor_vda.ToString().Replace(',','.')+"', '"+venda.Desct_vda+ "');");

        }
        public int UltVendas()
        {
            executarComando("select * from venda;");
            Compra.Ultvendas1 = Convert.ToInt32(tabela_memoria.Rows[0]["id_vda"].ToString());
            return Compra.Ultvendas1;

        }

        public Boolean pesquisarVenda(String idvdaa)
        {
            try
            {

                executarComando("select * from venda where id_vda = '"+idvdaa+"';");

                this.venda.Id_vda = Convert.ToInt32(tabela_memoria.Rows[0]["id_vda"].ToString());
                this.venda.Nome_cli1 = tabela_memoria.Rows[0]["Nome_cli"].ToString();
                this.venda.Id_pagto = Convert.ToInt32(tabela_memoria.Rows[0]["Id_pagto"].ToString());
                this.venda.Id_func = Convert.ToInt32(tabela_memoria.Rows[0]["Id_func"].ToString());
                this.venda.Data_vda = Convert.ToDateTime(tabela_memoria.Rows[0]["Data_vda"].ToString());
                this.venda.Valor_vda = Convert.ToDouble(tabela_memoria.Rows[0]["Valor_vda"].ToString());
                this.venda.Desct_vda = Convert.ToDouble(tabela_memoria.Rows[0]["Desct_vda"].ToString());

                return true;
            }
            catch
            {
                    
                return false;
            }
        }
       

        public DataTable listarTudo()
        {
            executarComando("select * from venda;");
            return tabela_memoria;
        }
        public void excluir(String idVenda)
        {
            executarComando("delete from venda where id_vda ='" + idVenda + "';");
        }
       
        public DataTable Total(Venda venda)
        {
            executarComando("select max('"+venda.Valor_vda+"') from venda");
            return tabela_memoria;
        }
        public void alterar(Venda venda)
        {
            executarComando("update venda set id_vda='" +venda.Id_vda+"', Nome_cli='"+venda.Nome_cli1+", id_pagto= '"+venda.Id_pagto+"', idfunc ='"+venda.Id_func+"', data_vda= '"+venda.Data_vda.ToString("yyyy/MM/dd") + "', valor_vda = '"+venda.Valor_vda.ToString().Replace('.', ',') + "', desct_vda ='"+venda.Desct_vda+"';" );
        }
    }
}
