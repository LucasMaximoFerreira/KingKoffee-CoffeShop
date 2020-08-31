namespace Cafeteria
{
    partial class funcPesq
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
            this.txtCepPesq = new System.Windows.Forms.TextBox();
            this.gvExibir = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibir)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCepPesq
            // 
            this.txtCepPesq.Location = new System.Drawing.Point(303, 50);
            this.txtCepPesq.Name = "txtCepPesq";
            this.txtCepPesq.Size = new System.Drawing.Size(184, 20);
            this.txtCepPesq.TabIndex = 7;
            this.txtCepPesq.TextChanged += new System.EventHandler(this.txtCepPesq_TextChanged);
            // 
            // gvExibir
            // 
            this.gvExibir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExibir.Location = new System.Drawing.Point(63, 86);
            this.gvExibir.Name = "gvExibir";
            this.gvExibir.Size = new System.Drawing.Size(483, 289);
            this.gvExibir.TabIndex = 6;
            this.gvExibir.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibir_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(58, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o CEP de entrega:";
            // 
            // funcPesq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCepPesq);
            this.Controls.Add(this.gvExibir);
            this.Controls.Add(this.label1);
            this.Name = "funcPesq";
            this.Size = new System.Drawing.Size(817, 473);
            this.Load += new System.EventHandler(this.funcPesq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvExibir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCepPesq;
        private System.Windows.Forms.DataGridView gvExibir;
        private System.Windows.Forms.Label label1;
    }
}
