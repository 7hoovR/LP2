namespace Ativ3
{
    partial class Form1
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
            this.lblValA = new System.Windows.Forms.Label();
            this.lblValB = new System.Windows.Forms.Label();
            this.lblValC = new System.Windows.Forms.Label();
            this.txtValA = new System.Windows.Forms.TextBox();
            this.txtValB = new System.Windows.Forms.TextBox();
            this.txtValC = new System.Windows.Forms.TextBox();
            this.btnVerTipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValA
            // 
            this.lblValA.AutoSize = true;
            this.lblValA.Location = new System.Drawing.Point(24, 29);
            this.lblValA.Name = "lblValA";
            this.lblValA.Size = new System.Drawing.Size(41, 13);
            this.lblValA.TabIndex = 0;
            this.lblValA.Text = "Valor A";
            // 
            // lblValB
            // 
            this.lblValB.AutoSize = true;
            this.lblValB.Location = new System.Drawing.Point(155, 29);
            this.lblValB.Name = "lblValB";
            this.lblValB.Size = new System.Drawing.Size(41, 13);
            this.lblValB.TabIndex = 1;
            this.lblValB.Text = "Valor B";
            // 
            // lblValC
            // 
            this.lblValC.AutoSize = true;
            this.lblValC.Location = new System.Drawing.Point(286, 29);
            this.lblValC.Name = "lblValC";
            this.lblValC.Size = new System.Drawing.Size(41, 13);
            this.lblValC.TabIndex = 2;
            this.lblValC.Text = "Valor C";
            // 
            // txtValA
            // 
            this.txtValA.Location = new System.Drawing.Point(27, 45);
            this.txtValA.Name = "txtValA";
            this.txtValA.Size = new System.Drawing.Size(100, 20);
            this.txtValA.TabIndex = 3;
            // 
            // txtValB
            // 
            this.txtValB.Location = new System.Drawing.Point(158, 45);
            this.txtValB.Name = "txtValB";
            this.txtValB.Size = new System.Drawing.Size(100, 20);
            this.txtValB.TabIndex = 4;
            // 
            // txtValC
            // 
            this.txtValC.Location = new System.Drawing.Point(289, 45);
            this.txtValC.Name = "txtValC";
            this.txtValC.Size = new System.Drawing.Size(100, 20);
            this.txtValC.TabIndex = 5;
            this.txtValC.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnVerTipo
            // 
            this.btnVerTipo.Location = new System.Drawing.Point(169, 90);
            this.btnVerTipo.Name = "btnVerTipo";
            this.btnVerTipo.Size = new System.Drawing.Size(75, 42);
            this.btnVerTipo.TabIndex = 6;
            this.btnVerTipo.Text = "Verificar tipo de triângulo";
            this.btnVerTipo.UseVisualStyleBackColor = true;
            this.btnVerTipo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 159);
            this.Controls.Add(this.btnVerTipo);
            this.Controls.Add(this.txtValC);
            this.Controls.Add(this.txtValB);
            this.Controls.Add(this.txtValA);
            this.Controls.Add(this.lblValC);
            this.Controls.Add(this.lblValB);
            this.Controls.Add(this.lblValA);
            this.Name = "Form1";
            this.Text = "Tipo triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValA;
        private System.Windows.Forms.Label lblValB;
        private System.Windows.Forms.Label lblValC;
        private System.Windows.Forms.TextBox txtValA;
        private System.Windows.Forms.TextBox txtValB;
        private System.Windows.Forms.TextBox txtValC;
        private System.Windows.Forms.Button btnVerTipo;
    }
}

