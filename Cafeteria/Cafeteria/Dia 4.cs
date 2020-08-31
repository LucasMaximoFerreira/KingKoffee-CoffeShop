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
    public partial class Dia_4 : UserControl
    {
        Produto prod = new Produto();
        ProdutosDAO prodDao = new ProdutosDAO();
        public Dia_4()
        {
            InitializeComponent();
        }

        private void Dia_4_Load(object sender, EventArgs e)
        {

        }

        private void btnComprarQuin_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 2;
            Compra.Compl_prod = ComplQuin.Text;
            Compra.Valor = 7.00;
            Compra.Qtd = Convert.ToInt32(nQuin.Value.ToString());
            Compra.Prod1 = "Cappuccino Gelado";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(nQuin.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            nQuin.Value = 0;
            ComplQuin.Text = "";

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
