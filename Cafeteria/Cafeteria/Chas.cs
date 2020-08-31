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
    public partial class Chas : UserControl
    {
        Produto prod = new Produto();
        ProdutosDAO prodDao = new ProdutosDAO();
        public Chas()
        {
            InitializeComponent();
        }

        private void btnComprarCha1_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 3;
            Compra.Compl_prod = Compl12.Text;
            Compra.Valor = 7.00;
            Compra.Qtd = Convert.ToInt32(n12.Value.ToString());
            Compra.Prod1 = "Chá quente ou gelado";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n12.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n12.Value = 0;
            Compl12.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void Chas_Load(object sender, EventArgs e)
        {

        }

        private void btnComprarCha2_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 3;
            Compra.Compl_prod = Compl13.Text;
            Compra.Valor = 7.00;
            Compra.Qtd = Convert.ToInt32(n13.Value.ToString());
            Compra.Prod1 = "Chai Latte";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n13.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            n13.Value = 0;
            Compl13.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;


            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnComprarCha3_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 3;
            Compra.Compl_prod = Compl14.Text;
            Compra.Valor = 7.00;
            Compra.Qtd = Convert.ToInt32(n14.Value.ToString());
            Compra.Prod1 = "Chá Gelado com Limonada";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n14.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            n14.Value = 0;
            Compl14.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;


            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnComprarCha4_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 3;
            Compra.Compl_prod = Compl15.Text;
            Compra.Valor = 7.00;
            Compra.Qtd = Convert.ToInt32(n15.Value.ToString());
            Compra.Prod1 = "Chá Verde Latte";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n15.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            n15.Value = 0;
            Compl15.Text = "";

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
