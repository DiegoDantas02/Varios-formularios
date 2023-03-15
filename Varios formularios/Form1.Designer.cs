namespace Varios_formularios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxInserir = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.textBoxMultitexto = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInserir
            // 
            this.textBoxInserir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxInserir.Location = new System.Drawing.Point(12, 38);
            this.textBoxInserir.Multiline = true;
            this.textBoxInserir.Name = "textBoxInserir";
            this.textBoxInserir.Size = new System.Drawing.Size(270, 23);
            this.textBoxInserir.TabIndex = 0;
            this.textBoxInserir.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Location = new System.Drawing.Point(288, 38);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(96, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // textBoxMultitexto
            // 
            this.textBoxMultitexto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxMultitexto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxMultitexto.Location = new System.Drawing.Point(12, 79);
            this.textBoxMultitexto.Multiline = true;
            this.textBoxMultitexto.Name = "textBoxMultitexto";
            this.textBoxMultitexto.Size = new System.Drawing.Size(372, 269);
            this.textBoxMultitexto.TabIndex = 2;
            this.textBoxMultitexto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(45, 367);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(309, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 402);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.textBoxMultitexto);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.textBoxInserir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Formulario ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInserir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox textBoxMultitexto;
        private System.Windows.Forms.Button btnLimpar;
    }
}

