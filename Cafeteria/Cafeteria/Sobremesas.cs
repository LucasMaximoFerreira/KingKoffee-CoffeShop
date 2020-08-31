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
    public partial class Sobremesas : UserControl
    {
        Produto prod = new Produto();

        ProdutosDAO prodDao = new ProdutosDAO();
        public Sobremesas()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnSob1_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 5;
            Compra.Compl_prod = Compl43.Text;
            Compra.Valor = 4.00;
            Compra.Qtd = Convert.ToInt32(n43.Value.ToString());
            Compra.Prod1 = "Bolo Triplo Brigadeiro";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n43.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n43.Value = 0;
            Compl43.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());


        }

        private void btnSob2_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 5;
            Compra.Compl_prod = Compl44.Text;
            Compra.Valor = 4.00;
            Compra.Qtd = Convert.ToInt32(n44.Value.ToString());
            Compra.Prod1 = "Waffle Belga";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n44.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n44.Value = 0;
            Compl44.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnSob3_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 5;
            Compra.Compl_prod = Compl45.Text;
            Compra.Valor = 4.00;
            Compra.Qtd = Convert.ToInt32(n45.Value.ToString());
            Compra.Prod1 = "Brownie de Chocolate com Doce de Leite";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n45.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n45.Value = 0;
            Compl45.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnSob4_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 5;
            Compra.Compl_prod = Compl46.Text;
            Compra.Valor = 4.00;
            Compra.Qtd = Convert.ToInt32(n46.Value.ToString());
            Compra.Prod1 = "Red Velvet";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n46.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n46.Value = 0;
            Compl46.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnSob5_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 5;
            Compra.Compl_prod = Compl47.Text;
            Compra.Valor = 6.00;
            Compra.Qtd = Convert.ToInt32(n47.Value.ToString());
            Compra.Prod1 = "Roll de Canela";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n47.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n47.Value = 0;
            Compl47.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnSob6_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 5;
            Compra.Compl_prod = Compl48.Text;
            Compra.Valor = 5.00;
            Compra.Qtd = Convert.ToInt32(n48.Value.ToString());
            Compra.Prod1 = "Espresso Brownie de Chocolate meio amargo";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n48.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n48.Value = 0;
            Compl48.Text = "";

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
