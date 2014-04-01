namespace LES
{
    partial class ConsultaContasaReceber
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtvencimentof = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvencimentoi = new System.Windows.Forms.TextBox();
            this.lblvencimentoi = new System.Windows.Forms.Label();
            this.txtEmissaof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmissaoi = new System.Windows.Forms.TextBox();
            this.lblemissãoi = new System.Windows.Forms.Label();
            this.gpbSituacao = new System.Windows.Forms.GroupBox();
            this.rbtodas = new System.Windows.Forms.RadioButton();
            this.rbbaixada = new System.Windows.Forms.RadioButton();
            this.rbaberto = new System.Windows.Forms.RadioButton();
            this.Duplicata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emissão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(589, 416);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(60, 23);
            this.btnLocalizar.TabIndex = 50;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(674, 416);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(60, 23);
            this.btnExcluir.TabIndex = 49;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(494, 416);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(60, 23);
            this.btnAlterar.TabIndex = 48;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(403, 416);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(60, 23);
            this.btnNovo.TabIndex = 47;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Duplicata,
            this.Serie,
            this.Valor,
            this.Emissão,
            this.Vencimento,
            this.Cliente,
            this.pagamento});
            this.dataGridView1.Location = new System.Drawing.Point(32, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 216);
            this.dataGridView1.TabIndex = 46;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(589, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(114, 20);
            this.textBox4.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Valor:";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(112, 71);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(401, 21);
            this.cbCliente.TabIndex = 42;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(64, 74);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 41;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtvencimentof
            // 
            this.txtvencimentof.Location = new System.Drawing.Point(588, 42);
            this.txtvencimentof.Name = "txtvencimentof";
            this.txtvencimentof.Size = new System.Drawing.Size(100, 20);
            this.txtvencimentof.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "a";
            // 
            // txtvencimentoi
            // 
            this.txtvencimentoi.Location = new System.Drawing.Point(463, 42);
            this.txtvencimentoi.Name = "txtvencimentoi";
            this.txtvencimentoi.Size = new System.Drawing.Size(100, 20);
            this.txtvencimentoi.TabIndex = 36;
            // 
            // lblvencimentoi
            // 
            this.lblvencimentoi.AutoSize = true;
            this.lblvencimentoi.Location = new System.Drawing.Point(379, 45);
            this.lblvencimentoi.Name = "lblvencimentoi";
            this.lblvencimentoi.Size = new System.Drawing.Size(81, 13);
            this.lblvencimentoi.TabIndex = 35;
            this.lblvencimentoi.Text = "Vencimento de ";
            // 
            // txtEmissaof
            // 
            this.txtEmissaof.Location = new System.Drawing.Point(260, 42);
            this.txtEmissaof.Name = "txtEmissaof";
            this.txtEmissaof.Size = new System.Drawing.Size(100, 20);
            this.txtEmissaof.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "a";
            // 
            // txtEmissaoi
            // 
            this.txtEmissaoi.Location = new System.Drawing.Point(112, 42);
            this.txtEmissaoi.Name = "txtEmissaoi";
            this.txtEmissaoi.Size = new System.Drawing.Size(100, 20);
            this.txtEmissaoi.TabIndex = 32;
            // 
            // lblemissãoi
            // 
            this.lblemissãoi.AutoSize = true;
            this.lblemissãoi.Location = new System.Drawing.Point(42, 45);
            this.lblemissãoi.Name = "lblemissãoi";
            this.lblemissãoi.Size = new System.Drawing.Size(64, 13);
            this.lblemissãoi.TabIndex = 31;
            this.lblemissãoi.Text = "Emissão de ";
            // 
            // gpbSituacao
            // 
            this.gpbSituacao.Controls.Add(this.rbtodas);
            this.gpbSituacao.Controls.Add(this.rbbaixada);
            this.gpbSituacao.Controls.Add(this.rbaberto);
            this.gpbSituacao.Location = new System.Drawing.Point(725, 33);
            this.gpbSituacao.Name = "gpbSituacao";
            this.gpbSituacao.Size = new System.Drawing.Size(128, 107);
            this.gpbSituacao.TabIndex = 52;
            this.gpbSituacao.TabStop = false;
            this.gpbSituacao.Text = "Situação";
            // 
            // rbtodas
            // 
            this.rbtodas.AutoSize = true;
            this.rbtodas.Location = new System.Drawing.Point(7, 64);
            this.rbtodas.Name = "rbtodas";
            this.rbtodas.Size = new System.Drawing.Size(55, 17);
            this.rbtodas.TabIndex = 3;
            this.rbtodas.TabStop = true;
            this.rbtodas.Text = "Todas";
            this.rbtodas.UseVisualStyleBackColor = true;
            // 
            // rbbaixada
            // 
            this.rbbaixada.AutoSize = true;
            this.rbbaixada.Location = new System.Drawing.Point(7, 41);
            this.rbbaixada.Name = "rbbaixada";
            this.rbbaixada.Size = new System.Drawing.Size(63, 17);
            this.rbbaixada.TabIndex = 1;
            this.rbbaixada.TabStop = true;
            this.rbbaixada.Text = "Baixada";
            this.rbbaixada.UseVisualStyleBackColor = true;
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
            // Duplicata
            // 
            this.Duplicata.HeaderText = "Duplicata";
            this.Duplicata.Name = "Duplicata";
            // 
            // Serie
            // 
            this.Serie.HeaderText = "Série";
            this.Serie.Name = "Serie";
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
            // pagamento
            // 
            this.pagamento.HeaderText = "Pagamento";
            this.pagamento.Name = "pagamento";
            // 
            // ConsultaContasaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 480);
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
            this.Controls.Add(this.txtvencimentof);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtvencimentoi);
            this.Controls.Add(this.lblvencimentoi);
            this.Controls.Add(this.txtEmissaof);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmissaoi);
            this.Controls.Add(this.lblemissãoi);
            this.Name = "ConsultaContasaReceber";
            this.Text = "ConsultaContasaReceber";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbSituacao.ResumeLayout(false);
            this.gpbSituacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtvencimentof;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvencimentoi;
        private System.Windows.Forms.Label lblvencimentoi;
        private System.Windows.Forms.TextBox txtEmissaof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmissaoi;
        private System.Windows.Forms.Label lblemissãoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duplicata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emissão;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamento;
        private System.Windows.Forms.GroupBox gpbSituacao;
        private System.Windows.Forms.RadioButton rbtodas;
        private System.Windows.Forms.RadioButton rbbaixada;
        private System.Windows.Forms.RadioButton rbaberto;
    }
}