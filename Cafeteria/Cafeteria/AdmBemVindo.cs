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
    public partial class AdmBemVindo : Form
    {
        Funcionario func = new Funcionario();

        FuncionarioDAO funcDao = new FuncionarioDAO();

        public AdmBemVindo()
        {
            InitializeComponent();
        }
       
        private void AdmBemVindo_Load(object sender, EventArgs e)
        {

        }

        private void btnPesqCli_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            caixa.ShowDialog();

        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            this.Close();
            BemVindosFunc bemvf = new BemVindosFunc();
            bemvf.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            X.ForeColor = Color.CadetBlue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            X.ForeColor = Color.White;
        }

        private void btnPesqProd_Click(object sender, EventArgs e)
        {
            PesquisarVenda pesqVenda = new PesquisarVenda();
            pesqVenda.ShowDialog();

        }
    }
}
