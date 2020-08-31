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
    public partial class BebidasButtons : UserControl
    {
        public BebidasButtons()
        {
            InitializeComponent();
        }

        private void BebidasButtons_Load(object sender, EventArgs e)
        {

        }

        private void btnCaf_Click(object sender, EventArgs e)
        {
             

            Cafes cafe = new Cafes();
            cafe.Dock = DockStyle.Fill;
            btnnn.Instance.Pnlpanel.Controls.Add(cafe);
            btnnn.Instance.Pnlpanel.Controls["Cafes"].BringToFront();
        }

        private void btnCha_Click(object sender, EventArgs e)
        {
            Chas cha = new Chas();
            cha.Dock = DockStyle.Fill;
            btnnn.Instance.Pnlpanel.Controls.Add(cha);
            btnnn.Instance.Pnlpanel.Controls["Chas"].BringToFront();
        }

        private void btnFra_Click(object sender, EventArgs e)
        {
            Frappuccino fra = new Frappuccino();
            fra.Dock = DockStyle.Fill;
            btnnn.Instance.Pnlpanel.Controls.Add(fra);
            btnnn.Instance.Pnlpanel.Controls["frappuccino"].BringToFront();
        }
    
    }
}
