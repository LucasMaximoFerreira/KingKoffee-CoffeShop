namespace Cafeteria
{
    partial class BebidasButtons
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
            this.btnFra = new System.Windows.Forms.Button();
            this.btnCha = new System.Windows.Forms.Button();
            this.btnCaf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFra
            // 
            this.btnFra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnFra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFra.FlatAppearance.BorderSize = 0;
            this.btnFra.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnFra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFra.Location = new System.Drawing.Point(432, 35);
            this.btnFra.Name = "btnFra";
            this.btnFra.Size = new System.Drawing.Size(154, 57);
            this.btnFra.TabIndex = 31;
            this.btnFra.Text = "Frappuccino";
            this.btnFra.UseVisualStyleBackColor = false;
            this.btnFra.Click += new System.EventHandler(this.btnFra_Click);
            // 
            // btnCha
            // 
            this.btnCha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnCha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCha.FlatAppearance.BorderSize = 0;
            this.btnCha.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnCha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCha.Location = new System.Drawing.Point(229, 35);
            this.btnCha.Name = "btnCha";
            this.btnCha.Size = new System.Drawing.Size(154, 57);
            this.btnCha.TabIndex = 30;
            this.btnCha.Text = "Chás";
            this.btnCha.UseVisualStyleBackColor = false;
            this.btnCha.Click += new System.EventHandler(this.btnCha_Click);
            // 
            // btnCaf
            // 
            this.btnCaf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnCaf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaf.FlatAppearance.BorderSize = 0;
            this.btnCaf.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnCaf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCaf.Location = new System.Drawing.Point(26, 35);
            this.btnCaf.Name = "btnCaf";
            this.btnCaf.Size = new System.Drawing.Size(154, 57);
            this.btnCaf.TabIndex = 29;
            this.btnCaf.Text = "Cafés";
            this.btnCaf.UseVisualStyleBackColor = false;
            this.btnCaf.Click += new System.EventHandler(this.btnCaf_Click);
            // 
            // BebidasButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFra);
            this.Controls.Add(this.btnCha);
            this.Controls.Add(this.btnCaf);
            this.Name = "BebidasButtons";
            this.Size = new System.Drawing.Size(613, 127);
            this.Load += new System.EventHandler(this.BebidasButtons_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFra;
        private System.Windows.Forms.Button btnCha;
        private System.Windows.Forms.Button btnCaf;
    }
}
