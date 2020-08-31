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
    public partial class Carrinho : UserControl
    {
        it_vdas itvdas = new it_vdas();
        double desc,sub;
        int pagamento;
        Venda venda = new Venda();
        it_vdasDAO itDao = new it_vdasDAO();
        VendaDAO vendaDao = new VendaDAO();
        Produto prod = new Produto();
        Cliente cli = new Cliente();
        double total;
        String CodCliente;
        int idprod;
        clienteDAO CliDao = new clienteDAO();
        
        ProdutosDAO prodDao = new ProdutosDAO();

        internal Produto Prod { get => prod; set => prod = value; }
        internal Venda Venda { get => venda; set => venda = value; }
        internal it_vdas Itvdas { get => itvdas; set => itvdas = value; }

        public Carrinho()
        {
            InitializeComponent();

        }


        private void Carrinho_Load(object sender, EventArgs e)
        {
            SubTotal.Text = Compra.ValorTotal1.ToString("#0.00");
            gvCarrinho.DataSource = prodDao.ListarProduto();
            Desconto.Text = desc.ToString();
            
            Compra.UltProd1 = prodDao.Prd();
           

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ValorTotal_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnAt_Click(object sender, EventArgs e)
        {
           if(Desconto.Text == string.Empty ||
                DataCompra.MaskFull == false ||
                grPagamento == null )
            {
                MessageBox.Show("Favor preencher os campos",
                   "ALERTA!!!!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);

                if (Desconto.Text == string.Empty)
                    Desconto.BackColor = Color.Red;
                if (DataCompra.MaskFull == false)
                    DataCompra.BackColor = Color.Red;
                if (grPagamento == null)
                    grPagamento.BackColor = Color.Red;

            }
            else
            {
                try
                {

                    venda.Nome_cli1 = Compra.Cli1;
                    venda.Data_vda = Convert.ToDateTime(DataCompra.Text);
                    venda.Valor_vda = Convert.ToDouble(ValorTotal.Text);
                    venda.Desct_vda = Convert.ToInt32(Desconto.Text);
                    venda.Id_pagto = pagamento;
                    vendaDao.inserir(venda);

                    SubTotal.Clear();
                    Desconto.Clear();
                    DataCompra.Clear();
                    ValorTotal.Clear();
                    Dinheiro.Checked = false;
                    Cartao.Checked = false;

                }
                catch (FormatException)
                {
                    MessageBox.Show("Favor verificar os campos digitados");
                }
            }

            

            if (this.gvCarrinho.DataSource != null)
            {
                this.gvCarrinho.DataSource = null;
            }
            else
            {

                this.gvCarrinho.Rows.Clear();
                
            }

            Compra.Ultvendas1 = vendaDao.UltVendas();

            itvdas.Id_prod = Compra.UltProd1;
            itvdas.Id_vda = Compra.Ultvendas1;
            itvdas.Qtd_it = Compra.QtdTotal1;
            itvdas.SubTot_it = Compra.Preco1;

            itDao.inserirItVendas(itvdas);
        }


        private void ExCompra_Click(object sender, EventArgs e)
        {
            if (gvCarrinho.Rows.Count > 0)
            {
                gvCarrinho.Rows.Remove(gvCarrinho.CurrentRow);
                SubTotal.Text = "R$" + (Convert.ToDouble(Compra.ValorTotal1.ToString()) - (Convert.ToDouble(Compra.Preco1.ToString())));
            }
            
        }
        

        private void gvCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Atu_Click(object sender, EventArgs e)
        {
            SubTotal.Text = "R$" + Convert.ToDouble(Compra.ValorTotal1.ToString());
            gvCarrinho.DataSource = prodDao.ListarProduto();
        }

        private void Desconto_TextChanged(object sender, EventArgs e)
        {

            Desconto.BackColor = Color.Empty;
            try
            {
                sub = Convert.ToDouble(SubTotal.Text);
                desc = Convert.ToInt32(Desconto.Text);
                ValorTotal.Text = (sub - (sub * (desc / 100))).ToString();
            }
            catch
            {

            }
        }

        private void Cartao_CheckedChanged(object sender, EventArgs e)
        {
            Cartao.BackColor = Color.Empty;
            Dinheiro.BackColor = Color.Empty;

            if (Cartao.Checked == true)
            {
                pagamento = 1;
            }
        }

        private void Dinheiro_CheckedChanged(object sender, EventArgs e)
        {
            Cartao.BackColor = Color.Empty;
            Dinheiro.BackColor = Color.Empty;

            if (Dinheiro.Checked == true)
            {
                pagamento = 2;
            }
        }

        private void DataCompra_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            DataCompra.BackColor = Color.Empty;
        }

        private void grPagamento_Enter(object sender, EventArgs e)
        {

        }

        private void SubTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }

