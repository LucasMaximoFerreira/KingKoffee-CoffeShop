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
    public partial class BemVindosFunc : Form
    {
        public BemVindosFunc()
        {
            InitializeComponent();
        }
      
        private void BemVindosFunc_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel6.Width += 10;
            if (panel6.Width >= 309)
            {
                timer2.Stop();
                this.Close();
                btnnn tela = new btnnn();
                tela.ShowDialog();
                



            }
        }
    }
}
