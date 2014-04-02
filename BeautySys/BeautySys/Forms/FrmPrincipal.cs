using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BeautySys.Classes;

namespace BeautySys.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "BeautySys - Versão: " + Application.ProductVersion + " - Usuário: " + LoginVO.Usuario;
            timer1.Enabled = true;
        }

        private void BtnCadUser_Click(object sender, EventArgs e)
        {
            FrmCadUser frmCadUser = new FrmCadUser();
            frmCadUser.ShowDialog();
        }

        private void btnCadTipoServico_Click(object sender, EventArgs e)
        {
            FrmTipoServico frmTipoServico = new FrmTipoServico();
            frmTipoServico.ShowDialog();
        }

        private void btnTipoProduto_Click(object sender, EventArgs e)
        {
            FrmTipoProduto frmTipoProduto = new FrmTipoProduto();
            frmTipoProduto.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = Convert.ToString(DateTime.Now);
        }
    }
}
