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
    public partial class Salgados : UserControl
    {
        Produto prod = new Produto();
        ProdutosDAO prodDao = new ProdutosDAO();
        public Salgados()
        {
            InitializeComponent();
        }

        private void btnSalg1_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 6;
            Compra.Compl_prod = Compl31.Text;
            Compra.Valor = 6.00;
            Compra.Qtd = Convert.ToInt32(n31.Value.ToString());
            Compra.Prod1 = "Pão de Queijo e Pão de Queijo Multigrãos";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n31.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n31.Value = 0;
            Compl31.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 6;
            Compra.Compl_prod = Compl32.Text;
            Compra.Valor = 5.50;
            Compra.Qtd = Convert.ToInt32(n32.Value.ToString());
            Compra.Prod1 = "Coxinha de Frango com Requeijão Cremoso";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n32.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n32.Value = 0;
            Compl32.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnSalg2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalg3_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 6;
            Compra.Compl_prod = Compl33.Text;
            Compra.Valor = 4.50;
            Compra.Qtd = Convert.ToInt32(n33.Value.ToString());
            Compra.Prod1 = "Empanada de Carne";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n33.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n33.Value = 0;
            Compl33.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnSalg4_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 6;
            Compra.Compl_prod = Compl34.Text;
            Compra.Valor = 3.50;
            Compra.Qtd = Convert.ToInt32(n34.Value.ToString());
            Compra.Prod1 = "Torrada Petrópolis";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n34.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n34.Value = 0;
            Compl34.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnSalg5_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 6;
            Compra.Compl_prod = Compl35.Text;
            Compra.Valor = 4.50;
            Compra.Qtd = Convert.ToInt32(n35.Value.ToString());
            Compra.Prod1 = "Croissant Multigrãos";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n35.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n35.Value = 0;
            Compl35.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnSalg6_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 6;
            Compra.Compl_prod = Compl36.Text;
            Compra.Valor = 4.50;
            Compra.Qtd = Convert.ToInt32(n36.Value.ToString());
            Compra.Prod1 = "Croissant: Frango ou Presunto e Queijo";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n36.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n36.Value = 0;
            Compl36.Text = "";

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
