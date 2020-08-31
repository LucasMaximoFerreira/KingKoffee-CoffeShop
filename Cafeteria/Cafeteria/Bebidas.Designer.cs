namespace Cafeteria
{
    partial class Bebidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bebidas));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FotoFra = new System.Windows.Forms.PictureBox();
            this.FotoCha = new System.Windows.Forms.PictureBox();
            this.FotoCafe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FotoFra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoCha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoCafe)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raphtalia DEMO", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(53, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 77);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cafés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raphtalia DEMO", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(342, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 77);
            this.label1.TabIndex = 33;
            this.label1.Text = "Chás";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raphtalia DEMO", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label3.Location = new System.Drawing.Point(546, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 77);
            this.label3.TabIndex = 34;
            this.label3.Text = "Frappuccino";
            // 
            // FotoFra
            // 
            this.FotoFra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoFra.Image = ((System.Drawing.Image)(resources.GetObject("FotoFra.Image")));
            this.FotoFra.Location = new System.Drawing.Point(566, 154);
            this.FotoFra.Name = "FotoFra";
            this.FotoFra.Size = new System.Drawing.Size(220, 161);
            this.FotoFra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoFra.TabIndex = 31;
            this.FotoFra.TabStop = false;
            // 
            // FotoCha
            // 
            this.FotoCha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoCha.Image = ((System.Drawing.Image)(resources.GetObject("FotoCha.Image")));
            this.FotoCha.Location = new System.Drawing.Point(292, 154);
            this.FotoCha.Name = "FotoCha";
            this.FotoCha.Size = new System.Drawing.Size(220, 161);
            this.FotoCha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoCha.TabIndex = 30;
            this.FotoCha.TabStop = false;
            this.FotoCha.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FotoCafe
            // 
            this.FotoCafe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoCafe.Image = ((System.Drawing.Image)(resources.GetObject("FotoCafe.Image")));
            this.FotoCafe.Location = new System.Drawing.Point(20, 154);
            this.FotoCafe.Name = "FotoCafe";
            this.FotoCafe.Size = new System.Drawing.Size(220, 161);
            this.FotoCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoCafe.TabIndex = 29;
            this.FotoCafe.TabStop = false;
            // 
            // Bebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FotoFra);
            this.Controls.Add(this.FotoCha);
            this.Controls.Add(this.FotoCafe);
            this.Name = "Bebidas";
            this.Size = new System.Drawing.Size(817, 423);
            this.Load += new System.EventHandler(this.Bebidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FotoFra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoCha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoCafe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox FotoCafe;
        private System.Windows.Forms.PictureBox FotoCha;
        private System.Windows.Forms.PictureBox FotoFra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
