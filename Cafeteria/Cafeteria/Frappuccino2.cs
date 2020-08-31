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
    public partial class Frappuccino2 : UserControl
    {
        Produto prod = new Produto();
        ProdutosDAO prodDao = new ProdutosDAO();
        public Frappuccino2()
        {
            InitializeComponent();
        }

        private void Seta5_Click(object sender, EventArgs e)
        {
            Frappuccino3 Fra3 = new Frappuccino3();
            Fra3.Dock = DockStyle.Fill;
            btnnn.Instance.Pnlpanel.Controls.Add(Fra3);
            btnnn.Instance.Pnlpanel.Controls["Frappuccino3"].BringToFront();
        }

        private void Seta4_Click(object sender, EventArgs e)
        {
            Frappuccino Fra = new Frappuccino();
            Fra.Dock = DockStyle.Fill;
            btnnn.Instance.Pnlpanel.Controls.Add(Fra);
            btnnn.Instance.Pnlpanel.Controls["Frappuccino"].BringToFront();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnComprarFrap21_Click(object sender, EventArgs e)
        {

            Compra.CodTipo1 = 2;
            Compra.Compl_prod = Compl22.Text;
            Compra.Valor = 6.00;
            Compra.Qtd = Convert.ToInt32(n22.Value.ToString());
            Compra.Prod1 = "Doce de leite Frappuccino";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n22.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n22.Value = 0;
            Compl22.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnComprarFrap22_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 2;
            Compra.Compl_prod = Compl23.Text;
            Compra.Valor = 7.50;
            Compra.Qtd = Convert.ToInt32(n23.Value.ToString());
            Compra.Prod1 = "Choco Chip Frappuccino";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n23.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n23.Value = 0;
            Compl23.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnComprarFrap23_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 2;
            Compra.Compl_prod = Compl24.Text;
            Compra.Valor = 6.50;
            Compra.Qtd = Convert.ToInt32(n24.Value.ToString());
            Compra.Prod1 = "Chocolate Frappuccino";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n24.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n24.Value = 0;
            Compl24.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnComprarFrap24_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 2;
            Compra.Compl_prod = Compl25.Text;
            Compra.Valor = 7.00;
            Compra.Qtd = Convert.ToInt32(n25.Value.ToString());
            Compra.Prod1 = "Chocolate Branco Frappuccino";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n25.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n25.Value = 0;
            Compl25.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void Frappuccino2_Load(object sender, EventArgs e)
        {

        }

        private void btnComprarFrap25_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 2;
            Compra.Compl_prod = Compl26.Text;
            Compra.Valor = 8.00;
            Compra.Qtd = Convert.ToInt32(n26.Value.ToString());
            Compra.Prod1 = "Chocolate Branco Frappuccino";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n26.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n26.Value = 0;
            Compl26.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnComprarFrap26_Click(object sender, EventArgs e)
        {

            Compra.CodTipo1 = 2;
            Compra.Compl_prod = Compl27.Text;
            Compra.Valor = 6.00;
            Compra.Qtd = Convert.ToInt32(n27.Value.ToString());
            Compra.Prod1 = "Baunilha Frappuccino";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n27.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n27.Value = 0;
            Compl27.Text = "";

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
