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
    public partial class LoginCli : Form
    {

        Cliente cliente = new Cliente();
        clienteDAO cliDAO = new clienteDAO();

        ProdutosDAO prodDao = new ProdutosDAO();
        Produto prod = new Produto();
     

        public LoginCli()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void btnloginCli_Click(object sender, EventArgs e)
        {

            cliente.Usuario_cli = txtUsu.Text;
            cliente.Senha_cli = txtSen.Text;
          
            if (cliDAO.verificarUsuario(cliente) == true)
            {
                BemVindos bv = new BemVindos(txtUsu.Text);
                bv.ShowDialog();
                Close();

                
            }


            else
            {
                MessageBox.Show("Nome de usuário ou senha inválido");
            }

           LoginCli form2 = new LoginCli();
           form2.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtUsu.Clear();
            picuser.BackgroundImage = Properties.Resources.user2;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtUsu.ForeColor = Color.FromArgb(78, 184, 206);

            picpass.BackgroundImage = Properties.Resources.pass2;
            panel2.BackColor = Color.WhiteSmoke;
            txtSen.ForeColor = Color.WhiteSmoke;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txtSen.Clear();
            txtSen.PasswordChar = '•';
            picpass.BackgroundImage = Properties.Resources.pass1;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtSen.ForeColor = Color.FromArgb(78, 184, 206);

            picuser.BackgroundImage = Properties.Resources.user1;
            panel1.BackColor = Color.WhiteSmoke;
            txtUsu.ForeColor = Color.WhiteSmoke;
        }

        private void picfb_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

       

      

        private void label2_Click(object sender, EventArgs e)
        {
            Close();           
        }



        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picgp_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void pictw_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }
     
      

        private void timer5_Tick(object sender, EventArgs e)
        {

        }

        private void timer6_Tick(object sender, EventArgs e)
        {

        }

        private void btnEsqueceuSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tente colocar Senha, caso não for, clique em OK e coloque seu e-mail aqui, pois iremos pedir uma confirmação por ele.", "Esqueceu a senha",
                MessageBoxButtons.OKCancel);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtSen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.CadetBlue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;

        }

        private void txtUsu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
