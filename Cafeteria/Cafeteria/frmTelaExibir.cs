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
    public partial class frmTelaExibir : Form
    {
        EntregaDAO entregaDAO = new EntregaDAO();
        Entrega entrega = new Entrega();
        public frmTelaExibir()
        {
            InitializeComponent();
        }

        internal EntregaDAO EntregaDAO { get => entregaDAO; set => entregaDAO = value; }
        internal Entrega Entrega { get => entrega; set => entrega = value; }

        private void frmTelaExibir_Load(object sender, EventArgs e)
        {
            entregaDAO.pesquisaEntregaId(dados.IdEntrega.ToString());

            txtRua.Text = entregaDAO.Entrega.Rua_entre;
            txtNumero.Text = entregaDAO.Entrega.Numero_entre.ToString();
            txtEstado.Text = entregaDAO.Entrega.Estado_entre;
            txtComplemento.Text = entregaDAO.Entrega.Complemento_entre;
            txtCidade.Text = entregaDAO.Entrega.Cidade_entre;
            txtBairro.Text = entregaDAO.Entrega.Bairro_entre;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
