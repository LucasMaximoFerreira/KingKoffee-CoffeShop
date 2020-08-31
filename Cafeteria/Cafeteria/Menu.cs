using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Cafeteria
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            LoginCli form2 = new LoginCli();
            form2.ShowDialog();
        }

        private void btnRegistrarCli_Click(object sender, EventArgs e)
        {
            Cadastrar form6 = new Cadastrar();
            form6.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            CadAdm adm = new CadAdm();
            adm.ShowDialog();
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Conexao.criar_Conexao();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.CadetBlue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }
    }
}
