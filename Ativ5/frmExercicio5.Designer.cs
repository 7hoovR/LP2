namespace Aula_02___Prática
{
    partial class frmExercicio5
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnSorteio = new System.Windows.Forms.Button();
            this.lblPrimeiro = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(124, 23);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(124, 62);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 1;
            // 
            // btnSorteio
            // 
            this.btnSorteio.Location = new System.Drawing.Point(233, 23);
            this.btnSorteio.Name = "btnSorteio";
            this.btnSorteio.Size = new System.Drawing.Size(96, 59);
            this.btnSorteio.TabIndex = 2;
            this.btnSorteio.Text = "Faz sorteio";
            this.btnSorteio.UseVisualStyleBackColor = true;
            this.btnSorteio.Click += new System.EventHandler(this.btnSorteio_Click);
            // 
            // lblPrimeiro
            // 
            this.lblPrimeiro.AutoSize = true;
            this.lblPrimeiro.Location = new System.Drawing.Point(25, 26);
            this.lblPrimeiro.Name = "lblPrimeiro";
            this.lblPrimeiro.Size = new System.Drawing.Size(84, 13);
            this.lblPrimeiro.TabIndex = 3;
            this.lblPrimeiro.Text = "Primeiro Número";
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Location = new System.Drawing.Point(25, 65);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(90, 13);
            this.lblSegundo.TabIndex = 4;
            this.lblSegundo.Text = "Segundo Número";
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 103);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.lblPrimeiro);
            this.Controls.Add(this.btnSorteio);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.Load += new System.EventHandler(this.frmExercicio5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnSorteio;
        private System.Windows.Forms.Label lblPrimeiro;
        private System.Windows.Forms.Label lblSegundo;
    }
}