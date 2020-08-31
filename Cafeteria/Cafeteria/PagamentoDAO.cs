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
    class PagamentoDAO
    {
        Pagamento pagto = new Pagamento();

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
        public void inserir(Pagamento pagto)
        {
            executarComando("insert into cargos values(0, '" + pagto.Tipo_pagto + "'");
        }
        public Boolean pesquisarPagamento(String id_pagto)
        {
            try
            {
                executarComando("SELECT * FROM pagamento WHERE id_pagto='" + id_pagto + "'");
                pagto.Id_pagto = Convert.ToInt32(tabela_memoria.Rows[0]["Id_pagto"].ToString());
                pagto.Tipo_pagto = tabela_memoria.Rows[0]["Tipo_pagto"].ToString();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable listarTudo()
        {
            executarComando("select * from pagamento;");
            return tabela_memoria;
        }
    }
}
