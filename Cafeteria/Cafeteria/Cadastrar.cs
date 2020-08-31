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
    public partial class Cadastrar : Form
    {

        Cliente cliente = new Cliente();

        clienteDAO clienteDAO = new clienteDAO();

        public Cadastrar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void txtUsu2_Click(object sender, EventArgs e)
        {
            txtUsu2.Clear();
            picuser2.BackgroundImage = Properties.Resources.user2;
            panelusu2.BackColor = Color.FromArgb(78, 184, 206);
            txtUsu2.ForeColor = Color.FromArgb(78, 184, 206);

            picpass2.BackgroundImage = Properties.Resources.pass2;
            panelsen2.BackColor = Color.WhiteSmoke;
            txtSen2.ForeColor = Color.WhiteSmoke;

            picmail2.BackgroundImage = Properties.Resources.email1;
            panelmail2.BackColor = Color.WhiteSmoke;
            picmail2.ForeColor = Color.WhiteSmoke;

            picphone2.BackgroundImage = Properties.Resources.phone_branco;
            panelphone2.BackColor = Color.WhiteSmoke;
            txtPhone2.ForeColor = Color.WhiteSmoke;

            piccid2.BackgroundImage = Properties.Resources.home_branco;
            panelcid2.BackColor = Color.WhiteSmoke;
            txtCid2.ForeColor = Color.WhiteSmoke;


            piccpf2.BackgroundImage = Properties.Resources.idcard_branco;
            panelcpf2.BackColor = Color.WhiteSmoke;
            txtCpf2.ForeColor = Color.WhiteSmoke;

            if (txtSen2.Text == string.Empty)
                txtSen2.Text = "Senha";
            if (txtMail2.Text == string.Empty)
                txtMail2.Text = "E-mail";
            if (txtPhone2.Text == string.Empty)
                txtPhone2.Text = "Telefone";
            if (txtCid2.Text == string.Empty)
                txtCid2.Text = "Cidade";
            if (txtCpf2.Text == string.Empty)
                txtCpf2.Text = "CPF";



            txtMail2.ForeColor = Color.WhiteSmoke;
        }

        private void txtSen2_Click(object sender, EventArgs e)
        {
            txtSen2.Clear();
            txtSen2.PasswordChar = '•';
            picpass2.BackgroundImage = Properties.Resources.pass1;
            panelsen2.BackColor = Color.FromArgb(78, 184, 206);
            txtSen2.ForeColor = Color.FromArgb(78, 184, 206);

            picuser2.BackgroundImage = Properties.Resources.user1;
            panelusu2.BackColor = Color.WhiteSmoke;
            txtUsu2.ForeColor = Color.WhiteSmoke;

            picmail2.BackgroundImage = Properties.Resources.email1;
            panelmail2.BackColor = Color.WhiteSmoke;
            picmail2.ForeColor = Color.WhiteSmoke;

            picphone2.BackgroundImage = Properties.Resources.phone_branco;
            panelphone2.BackColor = Color.WhiteSmoke;
            txtPhone2.ForeColor = Color.WhiteSmoke;

            piccid2.BackgroundImage = Properties.Resources.home_branco;
            panelcid2.BackColor = Color.WhiteSmoke;
            txtCid2.ForeColor = Color.WhiteSmoke;

        
            piccpf2.BackgroundImage = Properties.Resources.idcard_branco;
            panelcpf2.BackColor = Color.WhiteSmoke;
            txtCpf2.ForeColor = Color.WhiteSmoke;

            if (txtUsu2.Text == string.Empty)
                txtUsu2.Text = "Usuário";
            if (txtMail2.Text == string.Empty)
                txtMail2.Text = "E-mail";
            if (txtPhone2.Text == string.Empty)
                txtPhone2.Text = "Telefone";
            if (txtCid2.Text == string.Empty)
                txtCid2.Text = "Cidade";
            if (txtCpf2.Text == string.Empty)
                txtCpf2.Text = "CPF";
      


            txtMail2.ForeColor = Color.WhiteSmoke;
        }

        private void txtMail2_Click(object sender, EventArgs e)
        {
            txtMail2.Clear();
            picmail2.BackgroundImage = Properties.Resources.email_blue;
            panelmail2.BackColor = Color.FromArgb(78, 184, 206);
            txtMail2.ForeColor = Color.FromArgb(78, 184, 206);

            picuser2.BackgroundImage = Properties.Resources.user1;
            panelusu2.BackColor = Color.WhiteSmoke;
            txtUsu2.ForeColor = Color.WhiteSmoke;

            picpass2.BackgroundImage = Properties.Resources.pass2;
            panelsen2.BackColor = Color.WhiteSmoke;
            txtSen2.ForeColor = Color.WhiteSmoke;


            picphone2.BackgroundImage = Properties.Resources.phone_branco;
            panelphone2.BackColor = Color.WhiteSmoke;
            txtPhone2.ForeColor = Color.WhiteSmoke;

            piccid2.BackgroundImage = Properties.Resources.home_branco;
            panelcid2.BackColor = Color.WhiteSmoke;
            txtCid2.ForeColor = Color.WhiteSmoke;

        

            piccpf2.BackgroundImage = Properties.Resources.idcard_branco;
            panelcpf2.BackColor = Color.WhiteSmoke;
            txtCpf2.ForeColor = Color.WhiteSmoke;

            if (txtUsu2.Text == string.Empty)
                txtUsu2.Text = "Usuário";
            if (txtSen2.Text == string.Empty)
                txtSen2.Text = "Senha";
            if (txtPhone2.Text == string.Empty)
                txtPhone2.Text = "Telefone";
            if (txtCid2.Text == string.Empty)
                txtCid2.Text = "Cidade";
            if (txtCpf2.Text == string.Empty)
                txtCpf2.Text = "CPF";
           

        }

        private void txtPhone2_Click(object sender, EventArgs e)
        {
            txtPhone2.Clear();
            picphone2.BackgroundImage = Properties.Resources.phone_blue;
            panelphone2.BackColor = Color.FromArgb(78, 184, 206);
            txtPhone2.ForeColor = Color.FromArgb(78, 184, 206);

           
            picuser2.BackgroundImage = Properties.Resources.user1;
            panelusu2.BackColor = Color.WhiteSmoke;
            txtUsu2.ForeColor = Color.WhiteSmoke;

            picpass2.BackgroundImage = Properties.Resources.pass2;
            panelsen2.BackColor = Color.WhiteSmoke;
            txtSen2.ForeColor = Color.WhiteSmoke;

            picmail2.BackgroundImage = Properties.Resources.email1;
            panelmail2.BackColor = Color.WhiteSmoke;
            picmail2.ForeColor = Color.WhiteSmoke;

            piccid2.BackgroundImage = Properties.Resources.home_branco;
            panelcid2.BackColor = Color.WhiteSmoke;
            txtCid2.ForeColor = Color.WhiteSmoke;

         

            piccpf2.BackgroundImage = Properties.Resources.idcard_branco;
            panelcpf2.BackColor = Color.WhiteSmoke;
            txtCpf2.ForeColor = Color.WhiteSmoke;

            if (txtUsu2.Text == string.Empty)
                txtUsu2.Text = "Usuário";
            if (txtSen2.Text == string.Empty)
                txtSen2.Text = "Senha";
            if (txtMail2.Text == string.Empty)
                txtMail2.Text = "E-mail";
            if (txtCid2.Text == string.Empty)
                txtCid2.Text = "Cidade";
            if (txtCpf2.Text == string.Empty)
                txtCpf2.Text = "CPF";
        

            txtMail2.ForeColor = Color.WhiteSmoke;
        }

        private void txtCid2_Click(object sender, EventArgs e)
        {
            txtCid2.Clear();
            piccid2.BackgroundImage = Properties.Resources.home_blue;
            panelcid2.BackColor = Color.FromArgb(78, 184, 206);
            txtCid2.ForeColor = Color.FromArgb(78, 184, 206);

       

            picuser2.BackgroundImage = Properties.Resources.user1;
            panelusu2.BackColor = Color.WhiteSmoke;
            txtUsu2.ForeColor = Color.WhiteSmoke;

            picpass2.BackgroundImage = Properties.Resources.pass2;
            panelsen2.BackColor = Color.WhiteSmoke;
            txtSen2.ForeColor = Color.WhiteSmoke;

            picmail2.BackgroundImage = Properties.Resources.email1;
            panelmail2.BackColor = Color.WhiteSmoke;
            picmail2.ForeColor = Color.WhiteSmoke;

            picphone2.BackgroundImage = Properties.Resources.phone_branco;
            panelphone2.BackColor = Color.WhiteSmoke;
            txtPhone2.ForeColor = Color.WhiteSmoke;

     
            piccpf2.BackgroundImage = Properties.Resources.idcard_branco;
            panelcpf2.BackColor = Color.WhiteSmoke;
            txtCpf2.ForeColor = Color.WhiteSmoke;

            if (txtUsu2.Text == string.Empty)
                txtUsu2.Text = "Usuário";
            if (txtSen2.Text == string.Empty)
                txtSen2.Text = "Senha";
            if (txtMail2.Text == string.Empty)
                txtMail2.Text = "E-mail";
            if (txtPhone2.Text == string.Empty)
                txtPhone2.Text = "Telefone";
            if (txtCpf2.Text == string.Empty)
                txtCpf2.Text = "CPF";
         


            txtMail2.ForeColor = Color.WhiteSmoke;
        }

        private void txtCpf2_Click(object sender, EventArgs e)
        {
            txtCpf2.Clear();
            piccpf2.BackgroundImage = Properties.Resources.idcard_blue;
            panelcpf2.BackColor = Color.FromArgb(78, 184, 206);
            txtCpf2.ForeColor = Color.FromArgb(78, 184, 206);

            picuser2.BackgroundImage = Properties.Resources.user1;
            panelusu2.BackColor = Color.WhiteSmoke;
            txtUsu2.ForeColor = Color.WhiteSmoke;

            picpass2.BackgroundImage = Properties.Resources.pass2;
            panelsen2.BackColor = Color.WhiteSmoke;
            txtSen2.ForeColor = Color.WhiteSmoke;

            picmail2.BackgroundImage = Properties.Resources.email1;
            panelmail2.BackColor = Color.WhiteSmoke;
            picmail2.ForeColor = Color.WhiteSmoke;

            picphone2.BackgroundImage = Properties.Resources.phone_branco;
            panelphone2.BackColor = Color.WhiteSmoke;
            txtPhone2.ForeColor = Color.WhiteSmoke;
            
            piccid2.BackgroundImage = Properties.Resources.home_branco;
            panelcid2.BackColor = Color.WhiteSmoke;
            txtCid2.ForeColor = Color.WhiteSmoke;

            if (txtUsu2.Text == string.Empty)
                txtUsu2.Text = "Usuário";
            if (txtSen2.Text == string.Empty)
                txtSen2.Text = "Senha";
            if (txtMail2.Text == string.Empty)
                txtMail2.Text = "E-mail";
            if (txtPhone2.Text == string.Empty)
                txtPhone2.Text = "Telefone";
            if (txtCid2.Text == string.Empty)
                txtCid2.Text = "Cidade";
           

            txtMail2.ForeColor = Color.WhiteSmoke;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtUsu2.Text == string.Empty || txtUsu2.Text == "Usuário")
            {
                panelusu2.BackColor = Color.Red;
                picuser2.BackgroundImage = Properties.Resources.userRed;
                txtUsu2.Text = "Usuário";
                txtUsu2.ForeColor = Color.WhiteSmoke;

                MessageBox.Show("Favor preencher o campo usuário em vermelho",
                   "ALERTA!!!!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
            if (txtSen2.Text == string.Empty || txtSen2.Text == "Senha")
            {
                panelsen2.BackColor = Color.Red;
                picpass2.BackgroundImage = Properties.Resources.passRed;
                txtSen2.Text = "Senha";
                txtSen2.ForeColor = Color.WhiteSmoke;


                MessageBox.Show("Favor preencher o campo senha em vermelho",
                   "ALERTA!!!!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
            if (txtMail2.Text == string.Empty || txtMail2.Text == "E-mail")
            {
                panelmail2.BackColor = Color.Red;
                picmail2.BackgroundImage = Properties.Resources.emailRed2;
                txtMail2.Text = "E-mail";
                txtMail2.ForeColor = Color.WhiteSmoke;

                MessageBox.Show("Favor preencher o campo e-mail em vermelho",
                   "ALERTA!!!!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
            if (txtPhone2.Text == string.Empty || txtPhone2.Text == "Telefone")
            {
                panelphone2.BackColor = Color.Red;
                picphone2.BackgroundImage = Properties.Resources.phone_Red;
                txtPhone2.Text = "Telefone";
                txtPhone2.ForeColor = Color.WhiteSmoke;

                MessageBox.Show("Favor preencher o campo telefone em vermelho",
                   "ALERTA!!!!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
            if (txtCid2.Text == string.Empty || txtCid2.Text == "Cidade")
            {
                panelcid2.BackColor = Color.Red;
                piccid2.BackgroundImage = Properties.Resources.home_Red;
                txtCid2.Text = "Cidade";
                txtCid2.ForeColor = Color.WhiteSmoke;

                MessageBox.Show("Favor preencher o campo cidade em vermelho",
                   "ALERTA!!!!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
            if (txtCpf2.Text == string.Empty || txtCpf2.Text == "CPF")
            {
                panelcpf2.BackColor = Color.Red;
                piccpf2.BackgroundImage = Properties.Resources.idcard_Red;
                txtCpf2.Text = "CPF";
                txtCpf2.ForeColor = Color.WhiteSmoke;

                MessageBox.Show("Favor preencher o campo cpf em vermelho",
                   "ALERTA!!!!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cliente.Usuario_cli = txtUsu2.Text;
                    cliente.Senha_cli = txtSen2.Text;
                    cliente.Cpf_cli = txtCpf2.Text;
                    cliente.Tel_cli = txtPhone2.Text;
                    cliente.Cid_cli = txtCid2.Text;
                    cliente.Email_cli = txtMail2.Text;

                    clienteDAO.inserir(cliente);

                    gvExibir.DataSource = clienteDAO.listarTudo();
                }
                catch(FormatException)
                {
                    MessageBox.Show("Favor verificar os campos digitados!");
                }

            }
        }

        private void txtUsu2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void txtSen2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gvExibir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void gvExibir_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
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

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConfSen_TextChanged(object sender, EventArgs e)
        {

        }

        //private void ConfSen_Click(object sender, EventArgs e)
        //{
        //    ConfSen.Clear();
        //    ConfSen.PasswordChar = '•';
        //    picsen.BackgroundImage = Properties.Resources.pass2;
        //    panelconfsen.BackColor = Color.FromArgb(78, 184, 206);
        //    ConfSen.ForeColor = Color.FromArgb(78, 184, 206);

        //    picpass2.BackgroundImage = Properties.Resources.pass2;
        //    panelsen2.BackColor = Color.WhiteSmoke;
        //    txtSen2.ForeColor = Color.WhiteSmoke;
           
        //    picmail2.BackgroundImage = Properties.Resources.email1;
        //    panelmail2.BackColor = Color.WhiteSmoke;
        //    picmail2.ForeColor = Color.WhiteSmoke;

        //    picphone2.BackgroundImage = Properties.Resources.phone_branco;
        //    panelphone2.BackColor = Color.WhiteSmoke;
        //    txtPhone2.ForeColor = Color.WhiteSmoke;

        //    piccid2.BackgroundImage = Properties.Resources.home_branco;
        //    panelcid2.BackColor = Color.WhiteSmoke;
        //    txtCid2.ForeColor = Color.WhiteSmoke;

        //    piccpf2.BackgroundImage = Properties.Resources.idcard_branco;
        //    panelcpf2.BackColor = Color.WhiteSmoke;
        //    txtCpf2.ForeColor = Color.WhiteSmoke;

        //    if (txtUsu2.Text == string.Empty)
        //        txtUsu2.Text = "Usuário";
        //    if (txtMail2.Text == string.Empty)
        //        txtMail2.Text = "E-mail";
        //    if (txtPhone2.Text == string.Empty)
        //        txtPhone2.Text = "Telefone";
        //    if (txtCid2.Text == string.Empty)
        //        txtCid2.Text = "Cidade";
        //    if (txtCpf2.Text == string.Empty)
        //        txtCpf2.Text = "CPF";
        //    if (txtSen2.Text == string.Empty)
        //        txtSen2.Text = "Senha";

        //    txtMail2.ForeColor = Color.WhiteSmoke;
        //}
    }
}
