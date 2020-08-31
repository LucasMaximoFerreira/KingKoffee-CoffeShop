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
    public partial class BemVindos : Form
    {
        clienteDAO clienteDao = new clienteDAO();
        Cliente cliente = new Cliente();


        public BemVindos()
        {
            InitializeComponent();


        }
        public BemVindos(string texto)
        {
            InitializeComponent();
            Nomeusuario.Text = texto;

        }

        private void btnCont_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
            timer1.Stop();
        }

        private void btnCont_Click_1(object sender, EventArgs e)
        {
            btnnn cardapio = new btnnn();
            cardapio.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BemVindos_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            panel6.Width += 6;
            if (panel6.Width >= 309)
            {
                timer1.Stop();
                this.Close();
                btnnn tela = new btnnn(Nomeusuario.Text);
                tela.ShowDialog();




            }


        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.CadetBlue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
