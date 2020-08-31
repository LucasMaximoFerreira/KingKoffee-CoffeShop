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
    public partial class Sand : UserControl
    {

        Produto prod = new Produto();
        ProdutosDAO prodDao = new ProdutosDAO();
        public Sand()
        {
            InitializeComponent();
        }

        private void btnSand1_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 4;
            Compra.Compl_prod = Compl37.Text;
            Compra.Valor = 5.00;
            Compra.Qtd = Convert.ToInt32(n37.Value.ToString());
            Compra.Prod1 = "Croque Monsieur";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n37.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n37.Value = 0;
            Compl37.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnSand2_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 4;
            Compra.Compl_prod = Compl38.Text;
            Compra.Valor = 4.50;
            Compra.Qtd = Convert.ToInt32(n38.Value.ToString());
            Compra.Prod1 = "Toast de Peito de Peru";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n38.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n38.Value = 0;
            Compl38.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnSand3_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 4;
            Compra.Compl_prod = Compl39.Text;
            Compra.Valor = 4.00;
            Compra.Qtd = Convert.ToInt32(n39.Value.ToString());
            Compra.Prod1 = "Toast de Queijo com Tomate Confit";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n39.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n39.Value = 0;
            Compl39.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnSand4_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 4;
            Compra.Compl_prod = Compl40.Text;
            Compra.Valor = 4.50;
            Compra.Qtd = Convert.ToInt32(n40.Value.ToString());
            Compra.Prod1 = "Toast de Presunto";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n40.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n40.Value = 0;
            Compl40.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnSand5_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 4;
            Compra.Compl_prod = Compl41.Text;
            Compra.Valor = 6.00;
            Compra.Qtd = Convert.ToInt32(n41.Value.ToString());
            Compra.Prod1 = "Pork Barbecue";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n41.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n41.Value = 0;
            Compl41.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnSand6_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 4;
            Compra.Compl_prod = Compl42.Text;
            Compra.Valor = 5.00;
            Compra.Qtd = Convert.ToInt32(n42.Value.ToString());
            Compra.Prod1 = "Focaccia Vegetariana";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n42.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n42.Value = 0;
            Compl42.Text = "";

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
