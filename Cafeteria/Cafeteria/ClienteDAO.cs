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
    class clienteDAO
    {
        Cliente cliente = new Cliente();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;
        DataTable listaClientes;
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        public DataTable ListaClientes { get => listaClientes; set => listaClientes = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }
       
        public Boolean pesquisaCliente(String clientePesq)  
        {
            try
            {
                executarComando("select * from clientes where Usuario_cli = '" + clientePesq + "'; ");

                this.cliente.Id_cli = Convert.ToInt32(tabela_memoria.Rows[0]["Id_cli"].ToString());
                this.cliente.Usuario_cli = tabela_memoria.Rows[0]["Usuario_cli"].ToString();
                this.cliente.Senha_cli = tabela_memoria.Rows[0]["Senha_cli"].ToString();
                this.cliente.Cpf_cli = tabela_memoria.Rows[0]["Cpf_cli"].ToString();
                this.cliente.Tel_cli = tabela_memoria.Rows[0]["Tel_cli"].ToString();
                this.cliente.Cid_cli = tabela_memoria.Rows[0]["Cid_cli"].ToString();
                this.cliente.Email_cli = tabela_memoria.Rows[0]["Email_cli"].ToString();

                if (tabela_memoria.Rows.Count > 1)
                {
                    ListaClientes = tabela_memoria;

                }
                else
                {
                    listaClientes = null;
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
        public Boolean verificarUsuario(Cliente clienteV)
        {
            try
            {
                executarComando("select * from clientes where usuario_cli = '"+ clienteV.Usuario_cli+"' and senha_cli = '"+ clienteV.Senha_cli +"'");

                
                this.cliente.Usuario_cli = tabela_memoria.Rows[0]["Usuario_cli"].ToString();
                this.cliente.Senha_cli = tabela_memoria.Rows[0]["Senha_cli"].ToString();
                
                return true;
            }
            catch
            {
                return false;
            }

        }
        public void inserir(Cliente cliente)
        {
            executarComando("insert into clientes values(0, '"+cliente.Usuario_cli+"', '"+cliente.Senha_cli+"', '"+cliente.Cpf_cli+"', '"+cliente.Tel_cli+"', '"+cliente.Cid_cli+"', '"+cliente.Email_cli+"');");
        }
        public DataTable listarTudo()
        {
            executarComando("select id_cli, usuario_cli, cpf_cli, tel_cli, cid_cli, email_cli from clientes;");
            return tabela_memoria;
        }
        public void alterar(Cliente alt)
        {
            executarComando("update clientes set usuario_cli='"+alt.Usuario_cli+"', cpf_cli='"+ alt.Cpf_cli+"', tel_cli='"+ alt.Tel_cli+"', cid_cli='"+ alt.Cid_cli+"', email_cli='"+ alt.Email_cli+"' where id_cli='"+ alt.Id_cli+"';");

        }
        public void excluir(String UsuCli)
        {
            executarComando("delete from clientes where usuario_cli = '" + UsuCli+ "';");
        }
    }
}
