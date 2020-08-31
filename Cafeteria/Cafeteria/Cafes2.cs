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
    public partial class Cafes2 : UserControl
    {
        Produto prod = new Produto();
        ProdutosDAO prodDao = new ProdutosDAO();
        double preco;
        public Cafes2()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void Cafes2_Load(object sender, EventArgs e)
        {

        }

        private void Seta2_Click(object sender, EventArgs e)
        {
            Cafes caf = new Cafes();
            caf.Dock = DockStyle.Fill;
            btnnn.Instance.Pnlpanel.Controls.Add(caf);
            btnnn.Instance.Pnlpanel.Controls["Cafes"].BringToFront();
        }

        private void btnComprarCafe21_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 1;
            Compra.Compl_prod = Compl7.Text;
            Compra.Valor = 3.00;
            Compra.Qtd = Convert.ToInt32(n7.Value.ToString());
            Compra.Prod1 = "Café Latte";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n7.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            n7.Value = 0;
            Compl7.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;


            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());

        }

        private void btnComprarCafe24_Click(object sender, EventArgs e)
        {

            Compra.CodTipo1 = 1;
            Compra.Compl_prod = Compl8.Text;
            Compra.Valor = 3.50;
            Compra.Qtd = Convert.ToInt32(n8.Value.ToString());
            Compra.Prod1 = "Baunilha Latte";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n8.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            n8.Value = 0;
            Compl8.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;


            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());

        }

        private void btnComprarCafe22_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 1;
            Compra.Compl_prod = Compl9.Text;
            Compra.Valor = 3.50;
            Compra.Qtd = Convert.ToInt32(n9.Value.ToString());
            Compra.Prod1 = "Doce de leite Latte";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n9.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            n9.Value = 0;
            Compl9.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;


            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());

        }

        private void btnComprarCafe23_Click(object sender, EventArgs e)
        {

            Compra.CodTipo1 = 1;
            Compra.Compl_prod = Compl10.Text;
            Compra.Valor = 3.50;
            Compra.Qtd = Convert.ToInt32(n10.Value.ToString());
            Compra.Prod1 = "Café Mocha";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n10.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            n10.Value = 0;
            Compl10.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;


            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());

        }

        private void btnComprarCafe25_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 1;
            Compra.Compl_prod = Compl11.Text;
            Compra.Valor = 3.50;
            Compra.Qtd = Convert.ToInt32(n11.Value.ToString());
            Compra.Prod1 = "Caramelo Macchiato";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n11.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            n11.Value = 0;
            Compl11.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;


            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());

        }
    }
}
