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
    public partial class Cafes : UserControl
    {
        DataGridView grid;
        it_vdas itVdas = new it_vdas();
        it_vdasDAO itVdasDao = new it_vdasDAO();

        Cliente cli = new Cliente();
        clienteDAO cliDao = new clienteDAO();
        tipo_prod tipoP = new tipo_prod();
        tipo_prodDAO tipoDao = new tipo_prodDAO();
        Produto prod = new Produto();
        ProdutosDAO prodDao = new ProdutosDAO();
        it_vdasDAO itDao = new it_vdasDAO();

        double preco;

        VendaDAO vendaDao = new VendaDAO();

        Venda venda = new Venda();

        internal it_vdas itvdas { get; private set; }
        internal Cliente Cli { get => cli; set => cli = value; }

        public Cafes()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Seta1_Click(object sender, EventArgs e)
        {

            Cafes2 caf2 = new Cafes2();
            caf2.Dock = DockStyle.Fill;
            btnnn.Instance.Pnlpanel.Controls.Add(caf2);
            btnnn.Instance.Pnlpanel.Controls["Cafes2"].BringToFront();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }
      

        private void btnComprarCafe1_Click(object sender, EventArgs e)
        {

            Compra.CodTipo1 = 1;
            Compra.Compl_prod = Compl1.Text;
            Compra.Valor = 5.50;
            Compra.Qtd = Convert.ToInt32(n1.Value.ToString());
            Compra.Prod1 = "Prensa Francesa";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n1.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n1.Value = 0;
            Compl1.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());

        }
     


        private void btnComprarCafe2_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 1;
            Compra.Compl_prod = Compl2.Text;
            Compra.Valor = 3.00;
            Compra.Qtd = Convert.ToInt32(n2.Value.ToString());
            Compra.Prod1 = "Café Expresso";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n2.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n2.Value = 0;
            Compl2.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;

            prodDao.inserir(prod);
            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());

        }

        private void btnComprarCafe3_Click(object sender, EventArgs e)
        {

            Compra.CodTipo1 = 1;
            Compra.Compl_prod = Compl3.Text;
            Compra.Valor = 3.50;
            Compra.Qtd = Convert.ToInt32(n3.Value.ToString());
            Compra.Prod1 = "Café Com Leite";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n3.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            n3.Value = 0;
            Compl3.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;


            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());

        }

        private void btnComprarCafe4_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 1;
            Compra.Compl_prod = Compl4.Text;
            Compra.Valor = 4.00;
            Compra.Qtd = Convert.ToInt32(n4.Value.ToString());
            Compra.Prod1 = "Café Americano";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n4.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            n4.Value = 0;
            Compl4.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;


            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnComprarCafe5_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 1;
            Compra.Compl_prod = Compl5.Text;
            Compra.Valor = 3.50;
            Compra.Qtd = Convert.ToInt32(n5.Value.ToString());
            Compra.Prod1 = "Café Macchiato";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n5.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            n5.Value = 0;
            Compl5.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;


            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());

        }

        private void btnComprarCafe6_Click(object sender, EventArgs e)
        {

            Compra.CodTipo1 = 1;
            Compra.Compl_prod = Compl6.Text;
            Compra.Valor = 4.00;
            Compra.Qtd = Convert.ToInt32(n6.Value.ToString());
            Compra.Prod1 = "Café Mocha Branco";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n6.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            n6.Value = 0;
            Compl6.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;


            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());

        }

        private void Cafes_Load(object sender, EventArgs e)
        {

        }

        private void Compl1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void n1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
