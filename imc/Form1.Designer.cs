namespace imc
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labeltitulo = new System.Windows.Forms.Label();
            this.labelpeso = new System.Windows.Forms.Label();
            this.labelaltura = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttoncalcular = new System.Windows.Forms.Button();
            this.labelIMcresult = new System.Windows.Forms.Label();
            this.labelresultcal = new System.Windows.Forms.Label();
            this.labelcondicao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labeltitulo
            // 
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo.Location = new System.Drawing.Point(10, 9);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(225, 29);
            this.labeltitulo.TabIndex = 0;
            this.labeltitulo.Text = "Calculadora de IMC";
            this.labeltitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelpeso
            // 
            this.labelpeso.AutoSize = true;
            this.labelpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpeso.Location = new System.Drawing.Point(14, 58);
            this.labelpeso.Name = "labelpeso";
            this.labelpeso.Size = new System.Drawing.Size(45, 20);
            this.labelpeso.TabIndex = 1;
            this.labelpeso.Text = "Peso";
            // 
            // labelaltura
            // 
            this.labelaltura.AutoSize = true;
            this.labelaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaltura.Location = new System.Drawing.Point(14, 95);
            this.labelaltura.Name = "labelaltura";
            this.labelaltura.Size = new System.Drawing.Size(51, 20);
            this.labelaltura.TabIndex = 2;
            this.labelaltura.Text = "Altura";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 4;
            // 
            // buttoncalcular
            // 
            this.buttoncalcular.Location = new System.Drawing.Point(18, 140);
            this.buttoncalcular.Name = "buttoncalcular";
            this.buttoncalcular.Size = new System.Drawing.Size(198, 48);
            this.buttoncalcular.TabIndex = 5;
            this.buttoncalcular.Text = "Calcular";
            this.buttoncalcular.UseVisualStyleBackColor = true;
            this.buttoncalcular.Click += new System.EventHandler(this.buttoncalcular_Click);
            // 
            // labelIMcresult
            // 
            this.labelIMcresult.AutoSize = true;
            this.labelIMcresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIMcresult.Location = new System.Drawing.Point(68, 211);
            this.labelIMcresult.Name = "labelIMcresult";
            this.labelIMcresult.Size = new System.Drawing.Size(38, 20);
            this.labelIMcresult.TabIndex = 6;
            this.labelIMcresult.Text = "IMC";
            this.labelIMcresult.Click += new System.EventHandler(this.labelIMcresult_Click);
            // 
            // labelresultcal
            // 
            this.labelresultcal.AutoSize = true;
            this.labelresultcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresultcal.Location = new System.Drawing.Point(116, 211);
            this.labelresultcal.Name = "labelresultcal";
            this.labelresultcal.Size = new System.Drawing.Size(0, 16);
            this.labelresultcal.TabIndex = 7;
            // 
            // labelcondicao
            // 
            this.labelcondicao.AutoSize = true;
            this.labelcondicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcondicao.Location = new System.Drawing.Point(75, 279);
            this.labelcondicao.Name = "labelcondicao";
            this.labelcondicao.Size = new System.Drawing.Size(104, 31);
            this.labelcondicao.TabIndex = 8;
            this.labelcondicao.Text = "######";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 450);
            this.Controls.Add(this.labelcondicao);
            this.Controls.Add(this.labelresultcal);
            this.Controls.Add(this.labelIMcresult);
            this.Controls.Add(this.buttoncalcular);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelaltura);
            this.Controls.Add(this.labelpeso);
            this.Controls.Add(this.labeltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltitulo;
        private System.Windows.Forms.Label labelpeso;
        private System.Windows.Forms.Label labelaltura;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttoncalcular;
        private System.Windows.Forms.Label labelIMcresult;
        private System.Windows.Forms.Label labelresultcal;
        private System.Windows.Forms.Label labelcondicao;
    }
}

