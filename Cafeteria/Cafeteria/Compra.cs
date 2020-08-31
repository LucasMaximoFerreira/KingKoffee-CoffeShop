using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Cafeteria
{
   
    static class Compra
    {
        static string comprando = "Não";

        public static string Comprando { get => comprando; set => comprando = value; }
        public static double Total { get => total; set => total = value; }
        public static int Id_cli { get => id_cli; set => id_cli = value; }
        public static int Id_pagto { get => id_pagto; set => id_pagto = value; }
        public static int Id_func { get => id_func; set => id_func = value; }
        public static DateTime Data_vda { get => data_vda; set => data_vda = value; }
        public static DateTime Hora_vda { get => hora_vda; set => hora_vda = value; }
        public static double Valor_vda { get => valor_vda; set => valor_vda = value; }
        public static double Desct_vda { get => desct_vda; set => desct_vda = value; }
        public static double Valor { get => valor; set => valor = value; }
        public static string Prod1 { get => Prod; set => Prod = value; }
        public static int Qtd { get => qtd; set => qtd = value; }
        public static double Valortotal1 { get => Valortotal; set => Valortotal = value; }
        public static double Excluir1 { get => Excluir; set => Excluir = value; }
        public static double Preco1 { get => Preco; set => Preco = value; }
        public static ListView Lista { get => lista; set => lista = value; }
        public static double ValorTotal1 { get => ValorTotal; set => ValorTotal = value; }
        public static ListView ListView1 { get => ListView; set => ListView = value; }
        public static DataGridView GvCarrinho { get => gvCarrinho; set => gvCarrinho = value; }
        public static string Nome_tipo { get => nome_tipo; set => nome_tipo = value; }
        public static string Compl_prod { get => compl_prod; set => compl_prod = value; }
        public static double Preco2 { get => preco2; set => preco2 = value; }
        public static int CodTipo1 { get => CodTipo; set => CodTipo = value; }
        public static string CodCliente1 { get => CodCliente; set => CodCliente = value; }
        public static string TxtUsu2 { get => txtUsu2; set => txtUsu2 = value; }
        public static string Cli1 { get => Cli; set => Cli = value; }
        public static int Ultvendas1 { get => Ultvendas; set => Ultvendas = value; }
        public static int UltProd1 { get => UltProd; set => UltProd = value; }
        public static int QtdTotal1 { get => QtdTotal; set => QtdTotal = value; }

        static int QtdTotal;
        static int UltProd;
        static int Ultvendas;
        static string Cli;
        static string txtUsu2;
        static int CodTipo;
        static string CodCliente;
        static double preco2;
        static string compl_prod;
        static string nome_tipo;
        static double Preco;
        static double Excluir;
        static double Valortotal;
        //static void Main(string[] args)
        //{
        //    string[] produto = new string[55];
        //    produto[0] = "Café";
        //    produto[1] = "Prensa Francesa";
        //    produto[2] = "Café Expresso";
        //    produto[3] = "Café com Leite";
        //    produto[4] = "Café Americano";
        //    produto[5] = "Café Macchiato";
        //    produto[6] = "Café Mocha Branco";
        //    produto[7] = "Café Latte";
        //    produto[8] = "Baunilha Latte";
        //    produto[9] = "Doce de Leite Latte";
        //    produto[10] = "Café Mocha";
        //    produto[11] = "Caramelo Macchiato";
        //    produto[12] = "Chá Quente ou Gelado";
        //    produto[13] = "Chai Latte";
        //    produto[14] = "Cha gelado Com Limonada";
        //    produto[15] = "Cha Verde Latte";
        //    produto[16] = "Caramelo Macchiato Frappuccino";
        //    produto[17] = "Frappuccino Brigadeiro";
        //    produto[18] = "Café Frappuccino";
        //    produto[19] = "Mocha Frappuccino";
        //    produto[20] = "Mocha Branco Frappuccino";
        //    produto[21] = "Caramelo Frappuccino";
        //    produto[22] = "Doce de leite Frappuccino";
        //    produto[23] = "Choco Chip Frappuccino";
        //    produto[24] = "Chocolate Frappuccino";
        //    produto[25] = "Chocolate Branco Frappuccino";
        //    produto[26] = "Baunilha Frappuccino";
        //    produto[27] = "Morango Frappuccino";
        //    produto[28] = "Chai Frappuccino";
        //    produto[29] = "Chá verde Frappuccino";
        //    produto[30] = "Frapuccino Açaí";
        //    produto[31] = "Croque Monsieur";
        //    produto[32] = "Toast de Peito de Peru";
        //    produto[33] = "Toast de Queijo com Tomate Confit";
        //    produto[34] = "Toast de Presunto";
        //    produto[35] = "Pork Barbecue";
        //    produto[36] = "Focaccia Vegetariana";
        //    produto[37] = "Bolo Triplo Brigadeiro";
        //    produto[38] = "Waffle Belga";
        //    produto[39] = "Brownie de Chocolate com Doce de Leite";
        //    produto[40] = "Red Velvet";
        //    produto[41] = "Roll de Canela";
        //    produto[42] = "Espresso Brownie de Chocolate meio amargo";
        //    produto[43] = "Pão de Queijo e Pão de Queijo Multigrãos";
        //    produto[44] = "Coxinha de Frango com Requeijão Cremoso";
        //    produto[45] = "Empanada de Carne";
        //    produto[46] = "Torrada Petrópolis";
        //    produto[47] = "Croissant Multigrãos";
        //    produto[48] = "Croissant: Frango ou Presunto e Queijo";
        //    produto[49] = "Café Expresso";
        //    produto[50] = "Café com Leite";
        //    produto[51] = "Folhados";
        //    produto[52] = "Chá";
        //    produto[53] = "Bolos";
        //    produto[54] = "Pão de Queijo";
        //    produto[55] = "Cappuccino Gelado";



        //}
        static DataGridView gvCarrinho;
        static ListView ListView;
        static double ValorTotal;
        static ListView lista;
        static double total;
        static double valor;
        static int qtd;
        static string Prod;
        static int id_cli;
        static int id_pagto;
        static int id_func;
        static DateTime data_vda;
        static DateTime hora_vda;
        static double valor_vda;
        static double desct_vda;
    }
}
