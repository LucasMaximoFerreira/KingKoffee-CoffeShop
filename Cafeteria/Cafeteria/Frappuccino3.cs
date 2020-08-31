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
    public partial class Frappuccino3 : UserControl
    {
        Produto prod = new Produto();
        ProdutosDAO prodDao = new ProdutosDAO();
        public Frappuccino3()
        {
            InitializeComponent();
        }

        private void Seta6_Click(object sender, EventArgs e)
        {
            Frappuccino2 Fra2 = new Frappuccino2();
            Fra2.Dock = DockStyle.Fill;
            btnnn.Instance.Pnlpanel.Controls.Add(Fra2);
            btnnn.Instance.Pnlpanel.Controls["Frappuccino2"].BringToFront();
        }

        private void Frappuccino3_Load(object sender, EventArgs e)
        {

        }

        private void btnFra27_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 2;
            Compra.Compl_prod = Compl28.Text;
            Compra.Valor = 7.00;
            Compra.Qtd = Convert.ToInt32(n28.Value.ToString());
            Compra.Prod1 = "Chai Frappuccino";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n28.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n28.Value = 0;
            Compl28.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnFra28_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 2;
            Compra.Compl_prod = Compl29.Text;
            Compra.Valor = 6.50;
            Compra.Qtd = Convert.ToInt32(n29.Value.ToString());
            Compra.Prod1 = "Chá verde Frappuccino";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n29.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n29.Value = 0;
            Compl29.Text = "";

            prod.Id_tipo = Compra.CodTipo1;
            prod.Compl_prod = Compra.Compl_prod;
            prod.Valor_prod = Compra.Valor;
            prod.Qtd_prod = Compra.Qtd;
            prod.Nome_prod = Compra.Prod1;



            prodDao.inserir(prod);


            Compra.ValorTotal1 = Convert.ToDouble(Compra.Total.ToString());
        }

        private void btnFra29_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 2;
            Compra.Compl_prod = Compl30.Text;
            Compra.Valor = 5.50;
            Compra.Qtd = Convert.ToInt32(n30.Value.ToString());
            Compra.Prod1 = "Frapuccino Açaí";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(n30.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            n30.Value = 0;
            Compl30.Text = "";

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
