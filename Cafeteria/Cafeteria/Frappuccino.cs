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
    public partial class Frappuccino : UserControl
    {
        Produto prod = new Produto();
        ProdutosDAO prodDao = new ProdutosDAO();
        public Frappuccino()
        {
            InitializeComponent();
        }

        private void Seta3_Click(object sender, EventArgs e)
        {
            Frappuccino2 Fra2 = new Frappuccino2();
            Fra2.Dock = DockStyle.Fill;
            btnnn.Instance.Pnlpanel.Controls.Add(Fra2);
            btnnn.Instance.Pnlpanel.Controls["Frappuccino2"].BringToFront();
        }

        private void n4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void n5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void n6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnComprarFrap1_Click(object sender, EventArgs e)
        {

            Compra.CodTipo1 = 2;
            Compra.Compl_prod = Compl16.Text;
            Compra.Valor = 7.00;
            Compra.Qtd = Convert.ToInt32(n16.Value.ToString());
            Compra.Prod1 = "Caramelo Macchiato Frappuccino";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n16.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n16.Value = 0;
            Compl16.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnComprarFrap2_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 2;
            Compra.Compl_prod = Compl17.Text;
            Compra.Valor = 8.00;
            Compra.Qtd = Convert.ToInt32(n17.Value.ToString());
            Compra.Prod1 = "Frappuccino Brigadeiro";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n17.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n17.Value = 0;
            Compl17.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnComprarFrap3_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 2;
            Compra.Compl_prod = Compl18.Text;
            Compra.Valor = 6.00;
            Compra.Qtd = Convert.ToInt32(n18.Value.ToString());
            Compra.Prod1 = "Café Frappuccino";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n18.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n18.Value = 0;
            Compl18.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnComprarFrap4_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 2;
            Compra.Compl_prod = Compl19.Text;
            Compra.Valor = 6.50;
            Compra.Qtd = Convert.ToInt32(n19.Value.ToString());
            Compra.Prod1 = "Mocha Frappuccino";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n19.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n19.Value = 0;
            Compl19.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnComprarFrap5_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 2;
            Compra.Compl_prod = Compl20.Text;
            Compra.Valor = 7.50;
            Compra.Qtd = Convert.ToInt32(n20.Value.ToString());
            Compra.Prod1 = "Mocha Branco Frappuccino";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n20.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n20.Value = 0;
            Compl20.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnComprarFrap6_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 2;
            Compra.Compl_prod = Compl21.Text;
            Compra.Valor = 6.00;
            Compra.Qtd = Convert.ToInt32(n21.Value.ToString());
            Compra.Prod1 = "Caramelo Frappuccino";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n21.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n21.Value = 0;
            Compl21.Text = "";

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
