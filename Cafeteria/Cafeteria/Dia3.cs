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
    public partial class Dia3 : UserControl
    {
        Produto prod = new Produto();
        ProdutosDAO prodDao = new ProdutosDAO();
        public Dia3()
        {
            InitializeComponent();
        }

        private void Dia3_Load(object sender, EventArgs e)
        {

        }

        private void btnComprarQuar_Click(object sender, EventArgs e)
        {

            Compra.CodTipo1 = 5;
            Compra.Compl_prod = ComplQuar.Text;
            Compra.Valor = 2.50;
            Compra.Qtd = Convert.ToInt32(nQuar.Value.ToString());
            Compra.Prod1 = "Bolos";
            Compra.Preco1 = Convert.ToDouble(Compra.Valor.ToString()) * Convert.ToInt32(nQuar.Value.ToString());
            Compra.Total = Compra.Total + Compra.Preco1;
            Compra.QtdTotal1 = Compra.QtdTotal1 + Compra.Qtd;
            nQuar.Value = 0;
            ComplQuar.Text = "";

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
