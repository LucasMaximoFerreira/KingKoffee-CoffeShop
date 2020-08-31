namespace Cafeteria
{
    partial class Carrinho
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Desconto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValorTotal = new System.Windows.Forms.TextBox();
            this.btnAt = new System.Windows.Forms.Button();
            this.ExCompra = new System.Windows.Forms.Button();
            this.gvCarrinho = new System.Windows.Forms.DataGridView();
            this.Atu = new System.Windows.Forms.Button();
            this.DataCompra = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grPagamento = new System.Windows.Forms.GroupBox();
            this.Cartao = new System.Windows.Forms.RadioButton();
            this.Dinheiro = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvCarrinho)).BeginInit();
            this.grPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubTotal
            // 
            this.SubTotal.Location = new System.Drawing.Point(710, 237);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(100, 20);
            this.SubTotal.TabIndex = 1;
            this.SubTotal.TextChanged += new System.EventHandler(this.SubTotal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(601, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sub. Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desconto";
            // 
            // Desconto
            // 
            this.Desconto.Location = new System.Drawing.Point(710, 272);
            this.Desconto.Name = "Desconto";
            this.Desconto.Size = new System.Drawing.Size(100, 20);
            this.Desconto.TabIndex = 3;
            this.Desconto.TextChanged += new System.EventHandler(this.Desconto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Final";
            // 
            // ValorTotal
            // 
            this.ValorTotal.Location = new System.Drawing.Point(711, 308);
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Size = new System.Drawing.Size(100, 20);
            this.ValorTotal.TabIndex = 5;
            this.ValorTotal.TextChanged += new System.EventHandler(this.ValorTotal_TextChanged);
            // 
            // btnAt
            // 
            this.btnAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnAt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAt.FlatAppearance.BorderSize = 0;
            this.btnAt.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnAt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAt.Location = new System.Drawing.Point(631, 337);
            this.btnAt.Name = "btnAt";
            this.btnAt.Size = new System.Drawing.Size(154, 57);
            this.btnAt.TabIndex = 34;
            this.btnAt.Text = "Finalizar Compra";
            this.btnAt.UseVisualStyleBackColor = false;
            this.btnAt.Click += new System.EventHandler(this.btnAt_Click);
            // 
            // ExCompra
            // 
            this.ExCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ExCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExCompra.FlatAppearance.BorderSize = 0;
            this.ExCompra.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ExCompra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExCompra.Location = new System.Drawing.Point(17, 14);
            this.ExCompra.Name = "ExCompra";
            this.ExCompra.Size = new System.Drawing.Size(154, 57);
            this.ExCompra.TabIndex = 36;
            this.ExCompra.Text = "Excluir Compra";
            this.ExCompra.UseVisualStyleBackColor = false;
            this.ExCompra.Click += new System.EventHandler(this.ExCompra_Click);
            // 
            // gvCarrinho
            // 
            this.gvCarrinho.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCarrinho.Location = new System.Drawing.Point(16, 77);
            this.gvCarrinho.Name = "gvCarrinho";
            this.gvCarrinho.Size = new System.Drawing.Size(579, 317);
            this.gvCarrinho.TabIndex = 37;
            this.gvCarrinho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCarrinho_CellContentClick);
            // 
            // Atu
            // 
            this.Atu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.Atu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Atu.FlatAppearance.BorderSize = 0;
            this.Atu.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Atu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Atu.Location = new System.Drawing.Point(177, 14);
            this.Atu.Name = "Atu";
            this.Atu.Size = new System.Drawing.Size(154, 57);
            this.Atu.TabIndex = 38;
            this.Atu.Text = "Atualizar Compra";
            this.Atu.UseVisualStyleBackColor = false;
            this.Atu.Click += new System.EventHandler(this.Atu_Click);
            // 
            // DataCompra
            // 
            this.DataCompra.Location = new System.Drawing.Point(400, 47);
            this.DataCompra.Mask = "00/00/0000";
            this.DataCompra.Name = "DataCompra";
            this.DataCompra.Size = new System.Drawing.Size(99, 20);
            this.DataCompra.TabIndex = 39;
            this.DataCompra.ValidatingType = typeof(System.DateTime);
            this.DataCompra.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.DataCompra_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "Data";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // grPagamento
            // 
            this.grPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.grPagamento.Controls.Add(this.Cartao);
            this.grPagamento.Controls.Add(this.Dinheiro);
            this.grPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.grPagamento.Location = new System.Drawing.Point(605, 159);
            this.grPagamento.Name = "grPagamento";
            this.grPagamento.Size = new System.Drawing.Size(200, 61);
            this.grPagamento.TabIndex = 42;
            this.grPagamento.TabStop = false;
            this.grPagamento.Text = "Pagamento";
            this.grPagamento.Enter += new System.EventHandler(this.grPagamento_Enter);
            // 
            // Cartao
            // 
            this.Cartao.AutoSize = true;
            this.Cartao.Location = new System.Drawing.Point(18, 25);
            this.Cartao.Name = "Cartao";
            this.Cartao.Size = new System.Drawing.Size(75, 24);
            this.Cartao.TabIndex = 43;
            this.Cartao.TabStop = true;
            this.Cartao.Text = "Cartão";
            this.Cartao.UseVisualStyleBackColor = true;
            this.Cartao.CheckedChanged += new System.EventHandler(this.Cartao_CheckedChanged);
            // 
            // Dinheiro
            // 
            this.Dinheiro.AutoSize = true;
            this.Dinheiro.Location = new System.Drawing.Point(105, 25);
            this.Dinheiro.Name = "Dinheiro";
            this.Dinheiro.Size = new System.Drawing.Size(86, 24);
            this.Dinheiro.TabIndex = 44;
            this.Dinheiro.TabStop = true;
            this.Dinheiro.Text = "Dinheiro";
            this.Dinheiro.UseVisualStyleBackColor = true;
            this.Dinheiro.CheckedChanged += new System.EventHandler(this.Dinheiro_CheckedChanged);
            // 
            // panelc1
            // 
           
            // Carrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grPagamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataCompra);
            this.Controls.Add(this.Atu);
            this.Controls.Add(this.gvCarrinho);
            this.Controls.Add(this.ExCompra);
            this.Controls.Add(this.btnAt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ValorTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Desconto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubTotal);
            this.Name = "Carrinho";
            this.Size = new System.Drawing.Size(817, 423);
            this.Load += new System.EventHandler(this.Carrinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCarrinho)).EndInit();
            this.grPagamento.ResumeLayout(false);
            this.grPagamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SubTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Desconto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ValorTotal;
        private System.Windows.Forms.Button btnAt;
        private System.Windows.Forms.Button ExCompra;
        private System.Windows.Forms.DataGridView gvCarrinho;
        private System.Windows.Forms.Button Atu;
        private System.Windows.Forms.MaskedTextBox DataCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grPagamento;
        private System.Windows.Forms.RadioButton Cartao;
        private System.Windows.Forms.RadioButton Dinheiro;
    }
}
