using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class Delivery : UserControl
    {
        Entrega entrega = new Entrega();
        EntregaDAO entregaDAO = new EntregaDAO();

        public Delivery()
        {
            InitializeComponent();
        }

        private void btnpesqCEP_Click(object sender, EventArgs e)
        {
            ServiceReference2.AtendeClienteClient ws = new ServiceReference2.AtendeClienteClient("AtendeClientePort");
            var dados = ws.consultaCEP(txtCep.Text);
            if (dados != null)
            {
                lblRua.Text = dados.end;
                lblBairro.Text = dados.bairro;
                lblCidade.Text = dados.cidade;
                lblEstado.Text = dados.uf;
            } 
            else
            {
                lblRua.Text = "";
                lblBairro.Text = "";
                lblCidade.Text = "";
                lblEstado.Text = "";

                MessageBox.Show("CEP não encontrado.");
            }
        }
        private void limpar()
        {
            txtCep.Clear();
            txtComplemento.Clear();
            txtNumero.Clear();
            lblBairro.Text = "";
            lblCidade.Text = "";
            lblEstado.Text = "";
            lblRua.Text = "";

        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == String.Empty)
            {

                MessageBox.Show("Favor rever os campos digitados",
                   "Atenção!!!!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);

                if (txtComplemento.Text == String.Empty)
                {
                    entrega.Complemento_entre = txtComplemento.Text;
                }


                if (txtNumero.Text == string.Empty)
                    txtNumero.BackColor = Color.Red;
            }
            else
            {
                try
                {
                    entrega.Numero_entre = Convert.ToInt32(txtNumero.Text);
                    entrega.Rua_entre = lblRua.Text;
                    entrega.Estado_entre = lblEstado.Text;
                    entrega.Cidade_entre = lblCidade.Text;
                    entrega.Bairro_entre = lblBairro.Text;

                    entregaDAO.inserir(entrega);

                    MessageBox.Show("Pedido realizado com sucesso",
                  "Obrigado!",
                  MessageBoxButtons.OK);

                    limpar();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Favor verificar os campos digitados");

                }
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.BackColor = Color.Empty;
        }

        private void Delivery_Load(object sender, EventArgs e)
        {

        }
    }
}
