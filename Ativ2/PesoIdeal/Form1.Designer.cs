namespace PesoIdeal
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.mskbxAltura = new System.Windows.Forms.MaskedTextBox();
            this.lblPesoAtual = new System.Windows.Forms.Label();
            this.mskbxPesoAtual = new System.Windows.Forms.MaskedTextBox();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(40, 22);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(68, 13);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura (em m)";
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Checked = true;
            this.rbtnMasc.Location = new System.Drawing.Point(6, 19);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasc.TabIndex = 3;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "Masculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Location = new System.Drawing.Point(6, 55);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(67, 17);
            this.rbtnFem.TabIndex = 4;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "Feminino";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasc);
            this.gbxSexo.Controls.Add(this.rbtnFem);
            this.gbxSexo.Location = new System.Drawing.Point(191, 22);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(86, 85);
            this.gbxSexo.TabIndex = 6;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(112, 135);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(86, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // mskbxAltura
            // 
            this.mskbxAltura.Location = new System.Drawing.Point(31, 38);
            this.mskbxAltura.Name = "mskbxAltura";
            this.mskbxAltura.Size = new System.Drawing.Size(86, 20);
            this.mskbxAltura.TabIndex = 7;
            // 
            // lblPesoAtual
            // 
            this.lblPesoAtual.AutoSize = true;
            this.lblPesoAtual.Location = new System.Drawing.Point(40, 70);
            this.lblPesoAtual.Name = "lblPesoAtual";
            this.lblPesoAtual.Size = new System.Drawing.Size(57, 13);
            this.lblPesoAtual.TabIndex = 8;
            this.lblPesoAtual.Text = "Peso atual";
            // 
            // mskbxPesoAtual
            // 
            this.mskbxPesoAtual.Location = new System.Drawing.Point(31, 87);
            this.mskbxPesoAtual.Name = "mskbxPesoAtual";
            this.mskbxPesoAtual.Size = new System.Drawing.Size(86, 20);
            this.mskbxPesoAtual.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 189);
            this.Controls.Add(this.mskbxPesoAtual);
            this.Controls.Add(this.lblPesoAtual);
            this.Controls.Add(this.mskbxAltura);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.gbxSexo);
            this.Name = "Form1";
            this.Text = "Peso ideal";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.MaskedTextBox mskbxAltura;
        private System.Windows.Forms.Label lblPesoAtual;
        private System.Windows.Forms.MaskedTextBox mskbxPesoAtual;
    }
}

