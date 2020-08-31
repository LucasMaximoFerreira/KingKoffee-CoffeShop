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
    public partial class Dia2 : UserControl
    {

        Produto prod = new Produto();
        ProdutosDAO prodDao = new ProdutosDAO();
        public Dia2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnComprarTer_Click(object sender, EventArgs e)
        {

            Compra.CodTipo1 = 6;
            Compra.Compl_prod = ComplTer.Text;
            Compra.Valor = 4.50;
            Compra.Qtd = Convert.ToInt32(nTer.Value.ToString());
            Compra.Prod1 = "Pão de Queijo";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(nTer.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            nTer.Value = 0;
            ComplTer.Text = "";

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
