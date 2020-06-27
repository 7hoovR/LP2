namespace Aula_02___Prática
{
    partial class frmExercicio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNumerico = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnAlfabetico = new System.Windows.Forms.Button();
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnNumerico
            // 
            this.btnNumerico.Location = new System.Drawing.Point(21, 18);
            this.btnNumerico.Name = "btnNumerico";
            this.btnNumerico.Size = new System.Drawing.Size(134, 58);
            this.btnNumerico.TabIndex = 0;
            this.btnNumerico.Text = "Caracteres numéricos";
            this.btnNumerico.UseVisualStyleBackColor = true;
            this.btnNumerico.Click += new System.EventHandler(this.btnNumerico_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(187, 18);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(134, 58);
            this.btnBranco.TabIndex = 1;
            this.btnBranco.Text = "Primeiro caractere branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnAlfabetico
            // 
            this.btnAlfabetico.Location = new System.Drawing.Point(354, 18);
            this.btnAlfabetico.Name = "btnAlfabetico";
            this.btnAlfabetico.Size = new System.Drawing.Size(134, 58);
            this.btnAlfabetico.TabIndex = 2;
            this.btnAlfabetico.Text = "Caracteres alfabéticos";
            this.btnAlfabetico.UseVisualStyleBackColor = true;
            this.btnAlfabetico.Click += new System.EventHandler(this.btnAlfabetico_Click);
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(121, 86);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(266, 149);
            this.rchtxtTexto.TabIndex = 3;
            this.rchtxtTexto.Text = "";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 248);
            this.Controls.Add(this.rchtxtTexto);
            this.Controls.Add(this.btnAlfabetico);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNumerico);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.Load += new System.EventHandler(this.frmExercicio4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNumerico;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnAlfabetico;
        private System.Windows.Forms.RichTextBox rchtxtTexto;
    }
}