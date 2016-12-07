namespace HojaDeTrabajo1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_val1 = new System.Windows.Forms.TextBox();
            this.txt_val2 = new System.Windows.Forms.TextBox();
            this.txt_val3 = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_mcd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tercer Valor";
            // 
            // txt_val1
            // 
            this.txt_val1.Location = new System.Drawing.Point(140, 17);
            this.txt_val1.Name = "txt_val1";
            this.txt_val1.Size = new System.Drawing.Size(100, 22);
            this.txt_val1.TabIndex = 3;
            this.txt_val1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_val2
            // 
            this.txt_val2.Location = new System.Drawing.Point(140, 60);
            this.txt_val2.Name = "txt_val2";
            this.txt_val2.Size = new System.Drawing.Size(100, 22);
            this.txt_val2.TabIndex = 4;
            // 
            // txt_val3
            // 
            this.txt_val3.Location = new System.Drawing.Point(140, 109);
            this.txt_val3.Name = "txt_val3";
            this.txt_val3.Size = new System.Drawing.Size(100, 22);
            this.txt_val3.TabIndex = 5;
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(71, 185);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(100, 22);
            this.txt_resultado.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado";
            // 
            // btn_mcd
            // 
            this.btn_mcd.Location = new System.Drawing.Point(290, 12);
            this.btn_mcd.Name = "btn_mcd";
            this.btn_mcd.Size = new System.Drawing.Size(124, 46);
            this.btn_mcd.TabIndex = 8;
            this.btn_mcd.Text = "MCD";
            this.btn_mcd.UseVisualStyleBackColor = true;
            this.btn_mcd.Click += new System.EventHandler(this.btn_mcm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(436, 218);
            this.Controls.Add(this.btn_mcd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_val3);
            this.Controls.Add(this.txt_val2);
            this.Controls.Add(this.txt_val1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_val1;
        private System.Windows.Forms.TextBox txt_val2;
        private System.Windows.Forms.TextBox txt_val3;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_mcd;
    }
}

