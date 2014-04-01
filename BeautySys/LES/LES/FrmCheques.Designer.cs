namespace LES
{
    partial class FrmCheques
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
            this.lblNroCheque = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblEmissao = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbSituacao = new System.Windows.Forms.GroupBox();
            this.rbaberto = new System.Windows.Forms.RadioButton();
            this.rbbaixado = new System.Windows.Forms.RadioButton();
            this.rbdevolvido = new System.Windows.Forms.RadioButton();
            this.gpbSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNroCheque
            // 
            this.lblNroCheque.AutoSize = true;
            this.lblNroCheque.Location = new System.Drawing.Point(11, 53);
            this.lblNroCheque.Name = "lblNroCheque";
            this.lblNroCheque.Size = new System.Drawing.Size(101, 13);
            this.lblNroCheque.TabIndex = 0;
            this.lblNroCheque.Text = "Número do cheque:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(263, 56);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(41, 13);
            this.lblBanco.TabIndex = 2;
            this.lblBanco.Text = "Banco:";
            // 
            // cbBanco
            // 
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Location = new System.Drawing.Point(310, 53);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(168, 21);
            this.cbBanco.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(70, 143);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente:";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(118, 140);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(401, 21);
            this.cbCliente.TabIndex = 5;
            // 
            // lblEmissao
            // 
            this.lblEmissao.AutoSize = true;
            this.lblEmissao.Location = new System.Drawing.Point(63, 99);
            this.lblEmissao.Name = "lblEmissao";
            this.lblEmissao.Size = new System.Drawing.Size(49, 13);
            this.lblEmissao.TabIndex = 6;
            this.lblEmissao.Text = "Emissão:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(310, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vencimento:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(534, 53);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(114, 20);
            this.textBox4.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Valor:";
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(602, 202);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(60, 23);
            this.btnfechar.TabIndex = 25;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(427, 202);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(60, 23);
            this.btnLocalizar.TabIndex = 24;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(512, 202);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(60, 23);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(332, 202);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(60, 23);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(241, 202);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(60, 23);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // gpbSituacao
            // 
            this.gpbSituacao.Controls.Add(this.rbdevolvido);
            this.gpbSituacao.Controls.Add(this.rbbaixado);
            this.gpbSituacao.Controls.Add(this.rbaberto);
            this.gpbSituacao.Location = new System.Drawing.Point(534, 79);
            this.gpbSituacao.Name = "gpbSituacao";
            this.gpbSituacao.Size = new System.Drawing.Size(128, 100);
            this.gpbSituacao.TabIndex = 26;
            this.gpbSituacao.TabStop = false;
            this.gpbSituacao.Text = "Situação";
            // 
            // rbaberto
            // 
            this.rbaberto.AutoSize = true;
            this.rbaberto.Location = new System.Drawing.Point(7, 20);
            this.rbaberto.Name = "rbaberto";
            this.rbaberto.Size = new System.Drawing.Size(73, 17);
            this.rbaberto.TabIndex = 0;
            this.rbaberto.TabStop = true;
            this.rbaberto.Text = "Em aberto";
            this.rbaberto.UseVisualStyleBackColor = true;
            // 
            // rbbaixado
            // 
            this.rbbaixado.AutoSize = true;
            this.rbbaixado.Location = new System.Drawing.Point(7, 43);
            this.rbbaixado.Name = "rbbaixado";
            this.rbbaixado.Size = new System.Drawing.Size(63, 17);
            this.rbbaixado.TabIndex = 1;
            this.rbbaixado.TabStop = true;
            this.rbbaixado.Text = "Baixado";
            this.rbbaixado.UseVisualStyleBackColor = true;
            // 
            // rbdevolvido
            // 
            this.rbdevolvido.AutoSize = true;
            this.rbdevolvido.Location = new System.Drawing.Point(7, 64);
            this.rbdevolvido.Name = "rbdevolvido";
            this.rbdevolvido.Size = new System.Drawing.Size(73, 17);
            this.rbdevolvido.TabIndex = 2;
            this.rbdevolvido.TabStop = true;
            this.rbdevolvido.Text = "Devolvido";
            this.rbdevolvido.UseVisualStyleBackColor = true;
            // 
            // FrmCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 237);
            this.Controls.Add(this.gpbSituacao);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblEmissao);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbBanco);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNroCheque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCheques";
            this.Text = "Cadastro de Cheques";
            this.gpbSituacao.ResumeLayout(false);
            this.gpbSituacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroCheque;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.ComboBox cbBanco;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lblEmissao;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gpbSituacao;
        private System.Windows.Forms.RadioButton rbdevolvido;
        private System.Windows.Forms.RadioButton rbbaixado;
        private System.Windows.Forms.RadioButton rbaberto;
    }
}