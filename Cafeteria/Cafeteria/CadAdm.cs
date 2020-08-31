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
    public partial class CadAdm : Form
    {
        Funcionario func = new Funcionario();
        FuncionarioDAO funcDAO = new FuncionarioDAO();

           
        public CadAdm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoginAdm_Click(object sender, EventArgs e)
        {

            func.Nome_func = txtUsuAdm.Text;
            func.Senha_func = txtSenAdm.Text;

            if (funcDAO.verificarFuncionario(func) == true)
            {
                AdmBemVindo admin = new AdmBemVindo();
                admin.ShowDialog();
                Close();
  

            }


            else
            {
                MessageBox.Show("Nome do Funcionário ou senha inválido");
            }

            CadAdm adm = new CadAdm();
            adm.Close();
        }

        private void txtUsuAdm_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSenAdm_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadAdm_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuAdm_Click(object sender, EventArgs e)
        {
            txtUsuAdm.Clear();
            picuser.BackgroundImage = Properties.Resources.user2;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtUsuAdm.ForeColor = Color.FromArgb(78, 184, 206);

            picpass.BackgroundImage = Properties.Resources.pass2;
            panel2.BackColor = Color.WhiteSmoke;
            txtSenAdm.ForeColor = Color.WhiteSmoke;
        }

        private void txtSenAdm_Click(object sender, EventArgs e)
        {
            txtSenAdm.Clear();
            txtSenAdm.PasswordChar = '•';
            picpass.BackgroundImage = Properties.Resources.pass1;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtSenAdm.ForeColor = Color.FromArgb(78, 184, 206);

            picuser.BackgroundImage = Properties.Resources.user1;
            panel1.BackColor = Color.WhiteSmoke;
            txtUsuAdm.ForeColor = Color.WhiteSmoke;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.CadetBlue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }
    }
}
