namespace LES
{
    partial class FrmConsultaCheques
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
            this.lblemissãoi = new System.Windows.Forms.Label();
            this.txtEmissaoi = new System.Windows.Forms.TextBox();
            this.txtEmissaof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtvencimentof = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvencimentoi = new System.Windows.Forms.TextBox();
            this.lblvencimentoi = new System.Windows.Forms.Label();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NroCheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emissão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbSituacao = new System.Windows.Forms.GroupBox();
            this.rbdevolvido = new System.Windows.Forms.RadioButton();
            this.rbbaixado = new System.Windows.Forms.RadioButton();
            this.rbaberto = new System.Windows.Forms.RadioButton();
            this.rbtodos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblemissãoi
            // 
            this.lblemissãoi.AutoSize = true;
            this.lblemissãoi.Location = new System.Drawing.Point(22, 23);
            this.lblemissãoi.Name = "lblemissãoi";
            this.lblemissãoi.Size = new System.Drawing.Size(64, 13);
            this.lblemissãoi.TabIndex = 0;
            this.lblemissãoi.Text = "Emissão de ";
            // 
            // txtEmissaoi
            // 
            this.txtEmissaoi.Location = new System.Drawing.Point(92, 20);
            this.txtEmissaoi.Name = "txtEmissaoi";
            this.txtEmissaoi.Size = new System.Drawing.Size(100, 20);
            this.txtEmissaoi.TabIndex = 1;
            // 
            // txtEmissaof
            // 
            this.txtEmissaof.Location = new System.Drawing.Point(240, 20);
            this.txtEmissaof.Name = "txtEmissaof";
            this.txtEmissaof.Size = new System.Drawing.Size(100, 20);
            this.txtEmissaof.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "a";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtvencimentof
            // 
            this.txtvencimentof.Location = new System.Drawing.Point(568, 20);
            this.txtvencimentof.Name = "txtvencimentof";
            this.txtvencimentof.Size = new System.Drawing.Size(100, 20);
            this.txtvencimentof.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "a";
            // 
            // txtvencimentoi
            // 
            this.txtvencimentoi.Location = new System.Drawing.Point(443, 20);
            this.txtvencimentoi.Name = "txtvencimentoi";
            this.txtvencimentoi.Size = new System.Drawing.Size(100, 20);
            this.txtvencimentoi.TabIndex = 5;
            // 
            // lblvencimentoi
            // 
            this.lblvencimentoi.AutoSize = true;
            this.lblvencimentoi.Location = new System.Drawing.Point(359, 23);
            this.lblvencimentoi.Name = "lblvencimentoi";
            this.lblvencimentoi.Size = new System.Drawing.Size(81, 13);
            this.lblvencimentoi.TabIndex = 4;
            this.lblvencimentoi.Text = "Vencimento de ";
            // 
            // cbBanco
            // 
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Location = new System.Drawing.Point(92, 76);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(168, 21);
            this.cbBanco.TabIndex = 9;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(45, 79);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(41, 13);
            this.lblBanco.TabIndex = 8;
            this.lblBanco.Text = "Banco:";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(92, 49);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(401, 21);
            this.cbCliente.TabIndex = 11;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(44, 52);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(429, 77);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(114, 20);
            this.textBox4.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Valor:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroCheque,
            this.Banco,
            this.Valor,
            this.Emissão,
            this.Vencimento,
            this.Cliente});
            this.dataGridView1.Location = new System.Drawing.Point(12, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 216);
            this.dataGridView1.TabIndex = 17;
            // 
            // NroCheque
            // 
            this.NroCheque.HeaderText = "Nro Cheque";
            this.NroCheque.Name = "NroCheque";
            // 
            // Banco
            // 
            this.Banco.HeaderText = "Banco";
            this.Banco.Name = "Banco";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Emissão
            // 
            this.Emissão.HeaderText = "Emissão";
            this.Emissão.Name = "Emissão";
            // 
            // Vencimento
            // 
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 300;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(569, 394);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(60, 23);
            this.btnLocalizar.TabIndex = 29;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(654, 394);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(60, 23);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(474, 394);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(60, 23);
            this.btnAlterar.TabIndex = 27;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(383, 394);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(60, 23);
            this.btnNovo.TabIndex = 26;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // gpbSituacao
            // 
            this.gpbSituacao.Controls.Add(this.rbtodos);
            this.gpbSituacao.Controls.Add(this.rbdevolvido);
            this.gpbSituacao.Controls.Add(this.rbbaixado);
            this.gpbSituacao.Controls.Add(this.rbaberto);
            this.gpbSituacao.Location = new System.Drawing.Point(684, 20);
            this.gpbSituacao.Name = "gpbSituacao";
            this.gpbSituacao.Size = new System.Drawing.Size(128, 107);
            this.gpbSituacao.TabIndex = 31;
            this.gpbSituacao.TabStop = false;
            this.gpbSituacao.Text = "Situação";
            // 
            // rbdevolvido
            // 
            this.rbdevolvido.AutoSize = true;
            this.rbdevolvido.Location = new System.Drawing.Point(7, 60);
            this.rbdevolvido.Name = "rbdevolvido";
            this.rbdevolvido.Size = new System.Drawing.Size(73, 17);
            this.rbdevolvido.TabIndex = 2;
            this.rbdevolvido.TabStop = true;
            this.rbdevolvido.Text = "Devolvido";
            this.rbdevolvido.UseVisualStyleBackColor = true;
            // 
            // rbbaixado
            // 
            this.rbbaixado.AutoSize = true;
            this.rbbaixado.Location = new System.Drawing.Point(7, 41);
            this.rbbaixado.Name = "rbbaixado";
            this.rbbaixado.Size = new System.Drawing.Size(63, 17);
            this.rbbaixado.TabIndex = 1;
            this.rbbaixado.TabStop = true;
            this.rbbaixado.Text = "Baixado";
            this.rbbaixado.UseVisualStyleBackColor = true;
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
            // rbtodos
            // 
            this.rbtodos.AutoSize = true;
            this.rbtodos.Location = new System.Drawing.Point(6, 83);
            this.rbtodos.Name = "rbtodos";
            this.rbtodos.Size = new System.Drawing.Size(55, 17);
            this.rbtodos.TabIndex = 3;
            this.rbtodos.TabStop = true;
            this.rbtodos.Text = "Todos";
            this.rbtodos.UseVisualStyleBackColor = true;
            // 
            // FrmConsultaCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 429);
            this.Controls.Add(this.gpbSituacao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbBanco);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.txtvencimentof);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtvencimentoi);
            this.Controls.Add(this.lblvencimentoi);
            this.Controls.Add(this.txtEmissaof);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmissaoi);
            this.Controls.Add(this.lblemissãoi);
            this.Name = "FrmConsultaCheques";
            this.Text = "Cheques Recebidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbSituacao.ResumeLayout(false);
            this.gpbSituacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemissãoi;
        private System.Windows.Forms.TextBox txtEmissaoi;
        private System.Windows.Forms.TextBox txtEmissaof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvencimentof;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvencimentoi;
        private System.Windows.Forms.Label lblvencimentoi;
        private System.Windows.Forms.ComboBox cbBanco;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emissão;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gpbSituacao;
        private System.Windows.Forms.RadioButton rbtodos;
        private System.Windows.Forms.RadioButton rbdevolvido;
        private System.Windows.Forms.RadioButton rbbaixado;
        private System.Windows.Forms.RadioButton rbaberto;
    }
}