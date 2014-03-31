namespace BeautySys
{
    partial class FrmTipoServico
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblCodigoT = new System.Windows.Forms.Label();
            this.dgvTipoServico = new System.Windows.Forms.DataGridView();
            this.pk_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(273, 93);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(354, 64);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(273, 64);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(192, 64);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(260, 38);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(169, 20);
            this.txbNome.TabIndex = 14;
            // 
            // lblCodigoT
            // 
            this.lblCodigoT.AutoSize = true;
            this.lblCodigoT.Location = new System.Drawing.Point(196, 38);
            this.lblCodigoT.Name = "lblCodigoT";
            this.lblCodigoT.Size = new System.Drawing.Size(58, 13);
            this.lblCodigoT.TabIndex = 12;
            this.lblCodigoT.Text = "Descrição:";
            // 
            // dgvTipoServico
            // 
            this.dgvTipoServico.AllowUserToAddRows = false;
            this.dgvTipoServico.AllowUserToDeleteRows = false;
            this.dgvTipoServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pk_codigo,
            this.descricao});
            this.dgvTipoServico.Location = new System.Drawing.Point(12, 12);
            this.dgvTipoServico.Name = "dgvTipoServico";
            this.dgvTipoServico.ReadOnly = true;
            this.dgvTipoServico.Size = new System.Drawing.Size(174, 238);
            this.dgvTipoServico.TabIndex = 10;
            this.dgvTipoServico.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoServico_CellContentDoubleClick);
            // 
            // pk_codigo
            // 
            this.pk_codigo.HeaderText = "PK_CODIGO";
            this.pk_codigo.Name = "pk_codigo";
            this.pk_codigo.ReadOnly = true;
            this.pk_codigo.Visible = false;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descricao";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // txbCodigo
            // 
            this.txbCodigo.Enabled = false;
            this.txbCodigo.Location = new System.Drawing.Point(260, 12);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(125, 20);
            this.txbCodigo.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Código:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(192, 93);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmTipoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 262);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblCodigoT);
            this.Controls.Add(this.dgvTipoServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmTipoServico";
            this.Text = "Tipo de serviço";
            this.Load += new System.EventHandler(this.FrmTipo_Servico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblCodigoT;
        private System.Windows.Forms.DataGridView dgvTipoServico;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pk_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.Button btnLimpar;
    }
}