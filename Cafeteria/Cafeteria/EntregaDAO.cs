using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using WindowsFormsApp1;

namespace Cafeteria
{
    class EntregaDAO
    {
        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        Entrega entrega = new Entrega();

        internal Entrega Entrega { get => entrega; set => entrega = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }

        public void inserir(Entrega entrega)
        {
            executarComando("insert into entrega values(0,'" + entrega.Numero_entre + "','" + entrega.Complemento_entre + "','" + entrega.Rua_entre + "','" + entrega.Cidade_entre + "','" + entrega.Estado_entre + "','" + entrega.Bairro_entre + "','"+entrega.Cep_entre+"');");
        }


        public Boolean pesquisaEntregaId(String idEntregaPesq)
        {
            try
            {
                executarComando("Select * from entrega where id_entre = '" + idEntregaPesq + "'");
                Entrega.Rua_entre = tabela_memoria.Rows[0]["Rua_entre"].ToString();
                Entrega.Numero_entre = Convert.ToInt32(tabela_memoria.Rows[0]["Numero_entre"].ToString());
                Entrega.Cidade_entre = tabela_memoria.Rows[0]["Cidade_entre"].ToString(); ;
                Entrega.Bairro_entre = tabela_memoria.Rows[0]["Bairro_entre"].ToString();
                Entrega.Complemento_entre = tabela_memoria.Rows[0]["Complemento_entre"].ToString();
                Entrega.Estado_entre = tabela_memoria.Rows[0]["Estado_entre"].ToString();



                return true;

            }
            catch
            {
                return false;
            }
        }
        public DataTable listarTudo()
        {
            executarComando("select * from entrega;");
            return tabela_memoria;
        }

        public DataTable pesquisaFiltro(String cepPesq)
        {

            executarComando("SELECT * fROM ENTREGA WHERE CEP_ENTRE LIKE'" + cepPesq + "%'");
            return tabela_memoria;
        }

    }
}
