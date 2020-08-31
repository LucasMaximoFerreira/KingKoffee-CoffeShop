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
    public partial class funcPesq : UserControl
    {

        Entrega entrega = new Entrega();
        EntregaDAO entregaDAO = new EntregaDAO();
        public funcPesq()
        {
            InitializeComponent();
        }

        private void funcPesq_Load(object sender, EventArgs e)
        {

        }

        private void gvExibir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            int i = gvExibir.CurrentCell.RowIndex;

            dados.IdEntrega = Convert.ToInt32(gvExibir.Rows[i].Cells[0].Value.ToString());

            frmTelaExibir tela = new frmTelaExibir();
            tela.ShowDialog();
        }

        private void txtCepPesq_TextChanged(object sender, EventArgs e)
        {
            gvExibir.DataSource = entregaDAO.pesquisaFiltro(txtCepPesq.Text);

            gvExibir.Columns[0].Visible = true;
            gvExibir.Columns[0].HeaderText = "Numero do Pedido";
            gvExibir.Columns[0].Width = 148;

            gvExibir.Columns[1].Visible = true;
            gvExibir.Columns[1].HeaderText = "Numero da casa";
            gvExibir.Columns[1].Width = 146;

            gvExibir.Columns[2].Visible = false;
            gvExibir.Columns[3].Visible = false;
            gvExibir.Columns[4].Visible = false;
            gvExibir.Columns[5].Visible = false;

            gvExibir.Columns[6].Visible = true;
            gvExibir.Columns[6].HeaderText = "Bairro da entrega";
            gvExibir.Columns[6].Width = 146;

            gvExibir.Columns[7].Visible = false;
        }
    }
}
