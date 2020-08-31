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
    public partial class Dia6 : UserControl
    {
        Produto prod = new Produto();
        ProdutosDAO prodDao = new ProdutosDAO();
        public Dia6()
        {
            InitializeComponent();
        }

        private void btnComprarSab_Click(object sender, EventArgs e)
        {
            Compra.CodTipo1 = 6;
            Compra.Compl_prod = ComplSab.Text;
            Compra.Valor = 4.00;
            Compra.Qtd = Convert.ToInt32(nSab.Value.ToString());
            Compra.Prod1 = "Folhados";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(nSab.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            nSab.Value = 0;
            ComplSab.Text = "";

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
