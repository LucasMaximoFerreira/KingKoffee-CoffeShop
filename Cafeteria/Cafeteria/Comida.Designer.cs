namespace Cafeteria
{
    partial class Comida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comida));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FotoSalg = new System.Windows.Forms.PictureBox();
            this.FotoSob = new System.Windows.Forms.PictureBox();
            this.FotoSand = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FotoSalg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoSob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoSand)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raphtalia DEMO", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label3.Location = new System.Drawing.Point(571, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 77);
            this.label3.TabIndex = 40;
            this.label3.Text = "Salgados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raphtalia DEMO", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(275, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 77);
            this.label1.TabIndex = 39;
            this.label1.Text = "Sobremesas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raphtalia DEMO", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 77);
            this.label2.TabIndex = 38;
            this.label2.Text = "Sanduíches";
            // 
            // FotoSalg
            // 
            this.FotoSalg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoSalg.Image = ((System.Drawing.Image)(resources.GetObject("FotoSalg.Image")));
            this.FotoSalg.Location = new System.Drawing.Point(566, 154);
            this.FotoSalg.Name = "FotoSalg";
            this.FotoSalg.Size = new System.Drawing.Size(220, 161);
            this.FotoSalg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoSalg.TabIndex = 37;
            this.FotoSalg.TabStop = false;
            // 
            // FotoSob
            // 
            this.FotoSob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoSob.Image = ((System.Drawing.Image)(resources.GetObject("FotoSob.Image")));
            this.FotoSob.Location = new System.Drawing.Point(292, 154);
            this.FotoSob.Name = "FotoSob";
            this.FotoSob.Size = new System.Drawing.Size(220, 161);
            this.FotoSob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoSob.TabIndex = 36;
            this.FotoSob.TabStop = false;
            // 
            // FotoSand
            // 
            this.FotoSand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoSand.Image = ((System.Drawing.Image)(resources.GetObject("FotoSand.Image")));
            this.FotoSand.Location = new System.Drawing.Point(20, 154);
            this.FotoSand.Name = "FotoSand";
            this.FotoSand.Size = new System.Drawing.Size(220, 161);
            this.FotoSand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoSand.TabIndex = 35;
            this.FotoSand.TabStop = false;
            // 
            // Comida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FotoSalg);
            this.Controls.Add(this.FotoSob);
            this.Controls.Add(this.FotoSand);
            this.Name = "Comida";
            this.Size = new System.Drawing.Size(817, 423);
            ((System.ComponentModel.ISupportInitialize)(this.FotoSalg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoSob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoSand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox FotoSalg;
        private System.Windows.Forms.PictureBox FotoSob;
        private System.Windows.Forms.PictureBox FotoSand;
    }
}
