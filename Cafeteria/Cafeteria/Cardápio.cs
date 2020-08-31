using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cafeteria
{
    public partial class btnnn : Form
    {

        static btnnn _obj;

        public static btnnn Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new btnnn();
                }
                return _obj;
            }
        }




        public Panel Pnlpanel
        {
            get { return panel4; }
            set { panel4 = value; }
        }

        public Panel panelb
        {
            get { return panel3; }
            set { panel3 = value; }
        }        

        //public Button BackButton
        //{
        //    get { return btnBack; }
        //    set { btnBack = value; }
        //}

        //public Button BackButton2
        //{
        //    get { return btnBack2; }
        //    set { btnBack2 = value; }
        //}
        //public Button BackButton3
        //{
        //    get { return btnBack3; }
        //    set { btnBack3 = value; }
        //}

        //public Button BackButton4
        //{
        //    get { return btnBack4; }
        //    set { btnBack4 = value; }
        //}

        //public Button BackButton5
        //{
        //    get { return btnBack5; }
        //    set { btnBack5 = value; }
        //}

        //public Button BackButton6
        //{
        //    get { return btnBack6; }
        //    set { btnBack6 = value; }
        //}


        public btnnn()
        {
           
            InitializeComponent();
           
        }
        public btnnn(string NomeCli)
        {

            InitializeComponent();
            NCliente.Text = NomeCli;
            Compra.Cli1 = NCliente.Text;
        }


        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {


        }

        //----------------------------SEGUNDA-----------------------------

        private void btnSeg_Click(object sender, EventArgs e)
        {
            if (!btnnn.Instance.Pnlpanel.Controls.ContainsKey("Dia1"))
            {
                Dia1 inserir = new Dia1();
                inserir.Dock = DockStyle.Fill;
                btnnn.Instance.Pnlpanel.Controls.Add(inserir);




            }
            btnnn.Instance.Pnlpanel.Controls["Dia1"].BringToFront();


        }




        private void btnDom_Click(object sender, EventArgs e)
        {
            if (!btnnn.Instance.Pnlpanel.Controls.ContainsKey("Dia7"))
            {
                Dia7 Dia7 = new Dia7();
                Dia7.Dock = DockStyle.Fill;
                btnnn.Instance.Pnlpanel.Controls.Add(Dia7);




            }
            btnnn.Instance.Pnlpanel.Controls["Dia7"].BringToFront();


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQuar_Click(object sender, EventArgs e)
        {
            if (!btnnn.Instance.Pnlpanel.Controls.ContainsKey("Dia3"))
            {
                Dia3 Dia3 = new Dia3();
                Dia3.Dock = DockStyle.Fill;
                btnnn.Instance.Pnlpanel.Controls.Add(Dia3);




            }
            btnnn.Instance.Pnlpanel.Controls["Dia3"].BringToFront();
        }

        private void btnTer_Click(object sender, EventArgs e)
        {
            if (!btnnn.Instance.Pnlpanel.Controls.ContainsKey("Dia2"))
            {
                Dia2 Dia2 = new Dia2();
                Dia2.Dock = DockStyle.Fill;
                btnnn.Instance.Pnlpanel.Controls.Add(Dia2);




            }
            btnnn.Instance.Pnlpanel.Controls["Dia2"].BringToFront();
        }

        private void btnQuin_Click(object sender, EventArgs e)
        {
            if (!btnnn.Instance.Pnlpanel.Controls.ContainsKey("Dia4"))
            {
                Dia_4 Dia4 = new Dia_4();
                Dia4.Dock = DockStyle.Fill;
                btnnn.Instance.Pnlpanel.Controls.Add(Dia4);




            }
            btnnn.Instance.Pnlpanel.Controls["Dia_4"].BringToFront();

        }

        private void btnSex_Click(object sender, EventArgs e)
        {
            if (!btnnn.Instance.Pnlpanel.Controls.ContainsKey("Dia5"))
            {
                Dia5 Dia5 = new Dia5();
                Dia5.Dock = DockStyle.Fill;
                btnnn.Instance.Pnlpanel.Controls.Add(Dia5);




            }
            btnnn.Instance.Pnlpanel.Controls["Dia5"].BringToFront();

        }

        private void btnSab_Click(object sender, EventArgs e)
        {
            if (!btnnn.Instance.Pnlpanel.Controls.ContainsKey("Dia6"))
            {
                Dia6 Dia6 = new Dia6();
                Dia6.Dock = DockStyle.Fill;
                btnnn.Instance.Pnlpanel.Controls.Add(Dia6);




            }
            btnnn.Instance.Pnlpanel.Controls["Dia6"].BringToFront();
        }

        private void btnnn_Load(object sender, EventArgs e)
        {
            _obj = this;

          
            btnDom.Visible = false;
            btnTer.Visible = false;
            btnSab.Visible = false;
            btnQuar.Visible = false;
            btnQuin.Visible = false;
            btnSeg.Visible = false;
            btnSex.Visible = false;
            SidePanel.Visible = false;

            IntCard ins = new IntCard();
            ins.Dock = DockStyle.Fill;
            panel4.Controls.Add(ins);
        }

        private void btnOferta_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = true;

            SidePanel.Height = btnOferta.Height;
            SidePanel.Top = btnOferta.Top;


            btnDom.Visible = true;
            btnTer.Visible = true;
            btnSab.Visible = true;
            btnQuar.Visible = true;
            btnQuin.Visible = true;
            btnSeg.Visible = true;
            btnSex.Visible = true;
            _obj = this;


            Oferta of = new Oferta();
            of.Dock = DockStyle.Fill;
            panel4.Controls.Add(of);

            btnnn.Instance.Pnlpanel.Controls["Oferta"].BringToFront();

            panelb.Visible = false;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Bebidas_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = true;

            SidePanel.Height = Bebidas.Height;
            SidePanel.Top = Bebidas.Top;

            btnDom.Visible = false;
            btnTer.Visible = false;
            btnSab.Visible = false;
            btnQuar.Visible = false;
            btnQuin.Visible = false;
            btnSeg.Visible = false;
            btnSex.Visible = false;
          
            SidePanel.Height = Bebidas.Height;
            SidePanel.Top = Bebidas.Top;

            _obj = this;

            Bebidas bebidas = new Bebidas();
            bebidas.Dock = DockStyle.Fill;
            btnnn.Instance.Pnlpanel.Controls.Add(bebidas);
            btnnn.Instance.Pnlpanel.Controls["bebidas"].BringToFront();

            BebidasButtons bbb = new BebidasButtons();
            bbb.Dock = DockStyle.Fill;
            btnnn.Instance.panelb.Controls.Add(bbb);
            btnnn.Instance.panelb.Controls["BebidasButtons"].BringToFront();

            panelb.Visible = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = false;
            btnDom.Visible = false;
            btnTer.Visible = false;
            btnSab.Visible = false;
            btnQuar.Visible = false;
            btnQuin.Visible = false;
            btnSeg.Visible = false;
            btnSex.Visible = false;
            _obj = this;

            btnnn.Instance.Pnlpanel.Controls["intcard"].BringToFront();
            IntCard ins = new IntCard();
            ins.Dock = DockStyle.Fill;
            panel4.Controls.Add(ins);

            panelb.Visible = false;
        }

        private void Comidas_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = true;

            SidePanel.Height = Comidas.Height;
            SidePanel.Top = Comidas.Top;

            btnDom.Visible = false;
            btnTer.Visible = false;
            btnSab.Visible = false;
            btnQuar.Visible = false;
            btnQuin.Visible = false;
            btnSeg.Visible = false;
            btnSex.Visible = false;
          
            SidePanel.Height = Comidas.Height;
            SidePanel.Top = Comidas.Top;

            _obj = this;

            Comida comida = new Comida();
            comida.Dock = DockStyle.Fill;
            panel4.Controls.Add(comida);
            btnnn.Instance.Pnlpanel.Controls["comida"].BringToFront();

            Comidasbtn comidabtn = new Comidasbtn();
            comidabtn.Dock = DockStyle.Fill;
            btnnn.Instance.panelb.Controls.Add(comidabtn);
            btnnn.Instance.panelb.Controls["Comidasbtn"].BringToFront();

            panelb.Visible = true;


        }

        private void Delivery_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Delivery.Height;
            SidePanel.Top = Delivery.Top;

            btnDom.Visible = false;
            btnTer.Visible = false;
            btnSab.Visible = false;
            btnQuar.Visible = false;
            btnQuin.Visible = false;
            btnSeg.Visible = false;
            btnSex.Visible = false;
         

            SidePanel.Height = Delivery.Height;
            SidePanel.Top = Delivery.Top;

            _obj = this;


            cliFunc cli = new cliFunc();
            cli.Dock = DockStyle.Fill;
            btnnn.Instance.panelb.Controls.Add(cli);
            btnnn.Instance.panelb.Controls["cliFunc"].BringToFront();

           
        }

        private void Carrinho_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = true;

            SidePanel.Height = Comidas.Height;
            SidePanel.Top = Comidas.Top;

            SidePanel.Height = Carrinho.Height;
            SidePanel.Top = Carrinho.Top;

            _obj = this;

            Carrinho car = new Carrinho();
            car.Dock = DockStyle.Fill;
            btnnn.Instance.panel4.Controls.Add(car);
            btnnn.Instance.panel4.Controls["Carrinho"].BringToFront();

            FormCarrinho carr = new FormCarrinho();
            carr.Dock = DockStyle.Fill;
            btnnn.Instance.panelb.Controls.Add(carr);
            btnnn.Instance.panelb.Controls["FormCarrinho"].BringToFront();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPesqCli_Click(object sender, EventArgs e)
        {

        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button13.ForeColor = Color.CadetBlue;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.ForeColor = Color.White;
        }
    }
}