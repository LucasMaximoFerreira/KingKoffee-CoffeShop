using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class Caixa : Form
    {
        clienteDAO clienteDao = new clienteDAO();
        Cliente clientes = new Cliente();
        int qtdRegistro, i;
        string CodCliente;
        public Caixa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Caixa_Load(object sender, EventArgs e)
        {

        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            if (clienteDao.pesquisaCliente(txtPesq.Text) == true)
            {
                Compra.CodCliente1 = clienteDao.Cliente.Id_cli.ToString();


                txtNovaSenha.Text = clienteDao.Cliente.Senha_cli.ToString();
                txtNovoUsu.Text = clienteDao.Cliente.Usuario_cli.ToString();
                txtNovoEmail.Text = clienteDao.Cliente.Email_cli.ToString();
                txtNovoCPF.Text = clienteDao.Cliente.Cpf_cli.ToString();
                txtNovaCidade.Text = clienteDao.Cliente.Cid_cli.ToString();
                txtNovoTel.Text = clienteDao.Cliente.Tel_cli.ToString();

                if (clienteDao.Cliente == null)
                {
                    qtdRegistro = clienteDao.ListaClientes.Rows.Count;

                    i = 0;

                    setanext.Enabled = true;

                }
                else
                {
                    setanext.Enabled = false;
                    setaback.Enabled = false;
                }


            }
            else
            {
                MessageBox.Show("Cliente não cadastrado!!!");
                limpar();
            }

        }
        private void limpar()
        {
            txtPesq.Clear();
            txtNovoUsu.Clear();
            txtNovoEmail.Clear();
            txtNovoCPF.Clear();
            txtNovaCidade.Clear();
            txtNovoTel.Clear();
            txtNovaSenha.Clear();
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            clientes.Id_cli = clienteDao.Cliente.Id_cli;

            if (txtNovaSenha.Text == string.Empty ||
             txtNovoUsu.Text == string.Empty ||
             txtNovaCidade.Text == string.Empty ||
             txtNovoTel.Text == string.Empty ||
             txtNovoEmail.Text == string.Empty ||
             txtNovoCPF.Text == string.Empty)
            {
                MessageBox.Show("Favor preencher os campos",
                    "ALERTA!!!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    clientes.Id_cli = Convert.ToInt32(Compra.CodCliente1);

                    clientes.Senha_cli = txtNovaSenha.Text;
                    clientes.Usuario_cli = txtNovoUsu.Text;
                    clientes.Tel_cli = txtNovoTel.Text;
                    clientes.Cid_cli = txtNovaCidade.Text;
                    clientes.Cpf_cli = txtNovoCPF.Text;
                    clientes.Email_cli = txtNovoEmail.Text;

                    clienteDao.alterar(clientes);

                    MessageBox.Show("Cliente alterado com sucesso!!!");

                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;

                    setanext.Enabled = false;
                    setaback.Enabled = false;
                    limpar();
                }
                catch
                {
                    MessageBox.Show("Verifique as informações!!!");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult excl;

            excl = MessageBox.Show(
                "Deseja realmente excluir estas informações?",
                "Excluir cliente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (excl == DialogResult.Yes)
            {
                clienteDao.excluir(Compra.CodCliente1);
                MessageBox.Show("Compra excluído com sucesso!!");
            }
            else
            {
                MessageBox.Show("Cancelado!!");
            }

            limpar();
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

            setanext.Enabled = false;
            setaback.Enabled = false;
        }

        private void txtNovoId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.CadetBlue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void setaback_Click(object sender, EventArgs e)
        {
            setanext.Enabled = true;

            i--;

            if (i >= 0)
            {

                Compra.CodCliente1 = clienteDao.ListaClientes.Rows[i]["id_cli"].ToString();
                txtNovaSenha.Text = clienteDao.ListaClientes.Rows[i]["Senha_cli"].ToString();
                txtNovoUsu.Text = clienteDao.ListaClientes.Rows[i]["usuario_cli"].ToString();
                txtNovoEmail.Text = clienteDao.ListaClientes.Rows[i]["Email_cli"].ToString();
                txtNovoCPF.Text = clienteDao.ListaClientes.Rows[i]["Cpf_cli"].ToString();
                txtNovaCidade.Text = clienteDao.ListaClientes.Rows[i]["Cid_cli"].ToString();
                txtNovoTel.Text = clienteDao.ListaClientes.Rows[i]["Tel_cli"].ToString();


                if (i == 0)
                    setaback.Enabled = false;
            }
        }

        private void setanext_Click(object sender, EventArgs e)
        {
            setaback.Enabled = true;

            i++;

            if (i < qtdRegistro)
            {
                Compra.CodCliente1 = clienteDao.ListaClientes.Rows[i]["id_cli"].ToString();
                txtNovaSenha.Text = clienteDao.ListaClientes.Rows[i]["Senha_cli"].ToString();
                txtNovoUsu.Text = clienteDao.ListaClientes.Rows[i]["usuario_cli"].ToString();
                txtNovoEmail.Text = clienteDao.ListaClientes.Rows[i]["Email_cli"].ToString();
                txtNovoCPF.Text = clienteDao.ListaClientes.Rows[i]["Cpf_cli"].ToString();
                txtNovaCidade.Text = clienteDao.ListaClientes.Rows[i]["Cid_cli"].ToString();
                txtNovoTel.Text = clienteDao.ListaClientes.Rows[i]["Tel_cli"].ToString();


                if (i == qtdRegistro - 1)
                    setanext.Enabled = false;
            }
        }
    }
}

