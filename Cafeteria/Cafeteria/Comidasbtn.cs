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
    public partial class Comidasbtn : UserControl
    {
        public Comidasbtn()
        {
            InitializeComponent();
        }

        

        private void btnCha_Click(object sender, EventArgs e)
        {
            Sobremesas sobremesas = new Sobremesas();
            sobremesas.Dock = DockStyle.Fill;
            btnnn.Instance.Pnlpanel.Controls.Add(sobremesas);
            btnnn.Instance.Pnlpanel.Controls["Sobremesas"].BringToFront();
        }

        private void btnSand_Click(object sender, EventArgs e)
        {
            Sand sand = new Sand();
            sand.Dock = DockStyle.Fill;
            btnnn.Instance.Pnlpanel.Controls.Add(sand);
            btnnn.Instance.Pnlpanel.Controls["Sand"].BringToFront();
        }

        private void btnSalg_Click(object sender, EventArgs e)
        {
            Salgados salg = new Salgados();
            salg.Dock = DockStyle.Fill;
            btnnn.Instance.Pnlpanel.Controls.Add(salg);
            btnnn.Instance.Pnlpanel.Controls["Salgados"].BringToFront();
        }

        private void Comidasbtn_Load(object sender, EventArgs e)
        {

        }
    }
}
