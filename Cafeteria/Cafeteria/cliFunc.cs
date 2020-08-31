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
    public partial class cliFunc : UserControl
    {
        public cliFunc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delivery deli = new Delivery();
            deli.Dock = DockStyle.Fill;
            btnnn.Instance.Pnlpanel.Controls.Add(deli);
            btnnn.Instance.Pnlpanel.Controls["delivery"].BringToFront();

        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            funcPesq funcPesq = new funcPesq();
            funcPesq.Dock = DockStyle.Fill;
            btnnn.Instance.Pnlpanel.Controls.Add(funcPesq);
            btnnn.Instance.Pnlpanel.Controls["funcPesq"].BringToFront();

        }

        private void cliFunc_Load(object sender, EventArgs e)
        {

        }
    }
}
