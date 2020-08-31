namespace Cafeteria
{
    partial class Comidasbtn
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
            this.btnSalg = new System.Windows.Forms.Button();
            this.btnCha = new System.Windows.Forms.Button();
            this.btnSand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalg
            // 
            this.btnSalg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSalg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalg.FlatAppearance.BorderSize = 0;
            this.btnSalg.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSalg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalg.Location = new System.Drawing.Point(432, 35);
            this.btnSalg.Name = "btnSalg";
            this.btnSalg.Size = new System.Drawing.Size(154, 57);
            this.btnSalg.TabIndex = 34;
            this.btnSalg.Text = "Salgados";
            this.btnSalg.UseVisualStyleBackColor = false;
            this.btnSalg.Click += new System.EventHandler(this.btnSalg_Click);
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
            this.btnCha.TabIndex = 33;
            this.btnCha.Text = "Sobremesas";
            this.btnCha.UseVisualStyleBackColor = false;
            this.btnCha.Click += new System.EventHandler(this.btnCha_Click);
            // 
            // btnSand
            // 
            this.btnSand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSand.FlatAppearance.BorderSize = 0;
            this.btnSand.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSand.Location = new System.Drawing.Point(26, 35);
            this.btnSand.Name = "btnSand";
            this.btnSand.Size = new System.Drawing.Size(154, 57);
            this.btnSand.TabIndex = 32;
            this.btnSand.Text = "Sanduíches";
            this.btnSand.UseVisualStyleBackColor = false;
            this.btnSand.Click += new System.EventHandler(this.btnSand_Click);
            // 
            // Comidasbtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSalg);
            this.Controls.Add(this.btnCha);
            this.Controls.Add(this.btnSand);
            this.Name = "Comidasbtn";
            this.Size = new System.Drawing.Size(613, 127);
            this.Load += new System.EventHandler(this.Comidasbtn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalg;
        private System.Windows.Forms.Button btnCha;
        private System.Windows.Forms.Button btnSand;
    }
}
