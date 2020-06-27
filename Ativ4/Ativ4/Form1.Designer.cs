namespace Ativ4
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
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.lblAliqINSS = new System.Windows.Forms.Label();
            this.lblAliqIRPF = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblSalLiquido = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.mskbxNomeFunc = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.mskbxNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliqINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliqIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalFamilia = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalLiquido = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(17, 17);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(105, 13);
            this.lblNomeFunc.TabIndex = 0;
            this.lblNomeFunc.Text = "Nome do funcionário";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(17, 57);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(66, 13);
            this.lblSalBruto.TabIndex = 1;
            this.lblSalBruto.Text = "Salário bruto";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Location = new System.Drawing.Point(17, 101);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(86, 13);
            this.lblNumFilhos.TabIndex = 2;
            this.lblNumFilhos.Text = "Número de filhos";
            // 
            // lblAliqINSS
            // 
            this.lblAliqINSS.AutoSize = true;
            this.lblAliqINSS.Location = new System.Drawing.Point(17, 307);
            this.lblAliqINSS.Name = "lblAliqINSS";
            this.lblAliqINSS.Size = new System.Drawing.Size(75, 13);
            this.lblAliqINSS.TabIndex = 3;
            this.lblAliqINSS.Text = "Alíquota INSS";
            // 
            // lblAliqIRPF
            // 
            this.lblAliqIRPF.AutoSize = true;
            this.lblAliqIRPF.Location = new System.Drawing.Point(17, 335);
            this.lblAliqIRPF.Name = "lblAliqIRPF";
            this.lblAliqIRPF.Size = new System.Drawing.Size(74, 13);
            this.lblAliqIRPF.TabIndex = 4;
            this.lblAliqIRPF.Text = "Alíquota IRPF";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Location = new System.Drawing.Point(17, 363);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(73, 13);
            this.lblSalFamilia.TabIndex = 5;
            this.lblSalFamilia.Text = "Salário família";
            // 
            // lblSalLiquido
            // 
            this.lblSalLiquido.AutoSize = true;
            this.lblSalLiquido.Location = new System.Drawing.Point(17, 391);
            this.lblSalLiquido.Name = "lblSalLiquido";
            this.lblSalLiquido.Size = new System.Drawing.Size(74, 13);
            this.lblSalLiquido.TabIndex = 6;
            this.lblSalLiquido.Text = "Salário líquido";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Location = new System.Drawing.Point(330, 307);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(81, 13);
            this.lblDescINSS.TabIndex = 7;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Location = new System.Drawing.Point(330, 335);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(80, 13);
            this.lblDescIRPF.TabIndex = 8;
            this.lblDescIRPF.Text = "Desconto IRPF";
            // 
            // mskbxNomeFunc
            // 
            this.mskbxNomeFunc.Location = new System.Drawing.Point(154, 14);
            this.mskbxNomeFunc.Name = "mskbxNomeFunc";
            this.mskbxNomeFunc.Size = new System.Drawing.Size(125, 20);
            this.mskbxNomeFunc.TabIndex = 9;
            // 
            // mskbxSalBruto
            // 
            this.mskbxSalBruto.Location = new System.Drawing.Point(154, 54);
            this.mskbxSalBruto.Name = "mskbxSalBruto";
            this.mskbxSalBruto.Size = new System.Drawing.Size(125, 20);
            this.mskbxSalBruto.TabIndex = 10;
            // 
            // mskbxNumFilhos
            // 
            this.mskbxNumFilhos.Location = new System.Drawing.Point(154, 98);
            this.mskbxNumFilhos.Name = "mskbxNumFilhos";
            this.mskbxNumFilhos.Size = new System.Drawing.Size(125, 20);
            this.mskbxNumFilhos.TabIndex = 11;
            // 
            // mskbxAliqINSS
            // 
            this.mskbxAliqINSS.Location = new System.Drawing.Point(154, 304);
            this.mskbxAliqINSS.Name = "mskbxAliqINSS";
            this.mskbxAliqINSS.ReadOnly = true;
            this.mskbxAliqINSS.Size = new System.Drawing.Size(125, 20);
            this.mskbxAliqINSS.TabIndex = 12;
            // 
            // mskbxAliqIRPF
            // 
            this.mskbxAliqIRPF.Location = new System.Drawing.Point(154, 332);
            this.mskbxAliqIRPF.Name = "mskbxAliqIRPF";
            this.mskbxAliqIRPF.ReadOnly = true;
            this.mskbxAliqIRPF.Size = new System.Drawing.Size(125, 20);
            this.mskbxAliqIRPF.TabIndex = 13;
            // 
            // mskbxSalFamilia
            // 
            this.mskbxSalFamilia.Location = new System.Drawing.Point(154, 360);
            this.mskbxSalFamilia.Name = "mskbxSalFamilia";
            this.mskbxSalFamilia.ReadOnly = true;
            this.mskbxSalFamilia.Size = new System.Drawing.Size(125, 20);
            this.mskbxSalFamilia.TabIndex = 14;
            // 
            // mskbxSalLiquido
            // 
            this.mskbxSalLiquido.Location = new System.Drawing.Point(154, 388);
            this.mskbxSalLiquido.Name = "mskbxSalLiquido";
            this.mskbxSalLiquido.ReadOnly = true;
            this.mskbxSalLiquido.Size = new System.Drawing.Size(125, 20);
            this.mskbxSalLiquido.TabIndex = 15;
            // 
            // mskbxDescINSS
            // 
            this.mskbxDescINSS.Location = new System.Drawing.Point(467, 304);
            this.mskbxDescINSS.Name = "mskbxDescINSS";
            this.mskbxDescINSS.ReadOnly = true;
            this.mskbxDescINSS.Size = new System.Drawing.Size(125, 20);
            this.mskbxDescINSS.TabIndex = 16;
            // 
            // mskbxDescIRPF
            // 
            this.mskbxDescIRPF.Location = new System.Drawing.Point(467, 332);
            this.mskbxDescIRPF.Name = "mskbxDescIRPF";
            this.mskbxDescIRPF.ReadOnly = true;
            this.mskbxDescIRPF.Size = new System.Drawing.Size(125, 20);
            this.mskbxDescIRPF.TabIndex = 17;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(419, 140);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(105, 23);
            this.btnVerifica.TabIndex = 18;
            this.btnVerifica.Text = "Verificar desconto";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnFem);
            this.gbxSexo.Controls.Add(this.rbtnMasc);
            this.gbxSexo.Location = new System.Drawing.Point(421, 14);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(103, 100);
            this.gbxSexo.TabIndex = 19;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Location = new System.Drawing.Point(17, 55);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(67, 17);
            this.rbtnFem.TabIndex = 1;
            this.rbtnFem.Text = "Feminino";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Checked = true;
            this.rbtnMasc.Location = new System.Drawing.Point(17, 27);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasc.TabIndex = 0;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "Masculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(154, 144);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(77, 17);
            this.ckbxCasado.TabIndex = 20;
            this.ckbxCasado.Text = "Casado (a)";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbxCasado);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.mskbxDescIRPF);
            this.Controls.Add(this.mskbxDescINSS);
            this.Controls.Add(this.mskbxSalLiquido);
            this.Controls.Add(this.mskbxSalFamilia);
            this.Controls.Add(this.mskbxAliqIRPF);
            this.Controls.Add(this.mskbxAliqINSS);
            this.Controls.Add(this.mskbxNumFilhos);
            this.Controls.Add(this.mskbxSalBruto);
            this.Controls.Add(this.mskbxNomeFunc);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblSalLiquido);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblAliqIRPF);
            this.Controls.Add(this.lblAliqINSS);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNomeFunc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.Label lblAliqINSS;
        private System.Windows.Forms.Label lblAliqIRPF;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblSalLiquido;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxNomeFunc;
        private System.Windows.Forms.MaskedTextBox mskbxSalBruto;
        private System.Windows.Forms.MaskedTextBox mskbxNumFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxAliqINSS;
        private System.Windows.Forms.MaskedTextBox mskbxAliqIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxSalFamilia;
        private System.Windows.Forms.MaskedTextBox mskbxSalLiquido;
        private System.Windows.Forms.MaskedTextBox mskbxDescINSS;
        private System.Windows.Forms.MaskedTextBox mskbxDescIRPF;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.Label label1;
    }
}

