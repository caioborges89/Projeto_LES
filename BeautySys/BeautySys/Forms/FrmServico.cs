using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BeautySys.Business;
using BeautySys.Classes;
using BeautySys.Util;

namespace BeautySys
{
    public partial class FrmServico : Form
    {
        List<ServicoVO> lista = new List<ServicoVO>();
        ServicoBO _servicoBO = new ServicoBO();
        ServicoVO _servicoVO = new ServicoVO();

        public FrmServico()
        {
            InitializeComponent();
        }

#region "Métodos"

        private void limparObjetos()
        {
            txtCodigo.Clear();
            txtComissao.Clear();
            txtCusto.Clear();
            txtDescMaximo.Clear();
            txtDuracao.Clear();
            txtNome.Clear();
            txtObs.Clear();
            txtValor.Clear();
            cbTipoServico.Text = "";
            GC.Collect();
        }

        private void preencherDtgrid()
        {
            limparObjetos();

            lista = _servicoBO.buscarServico(new ServicoVO());

            dgvServicos.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgvServicos.Rows.Add(lista[i].pk_codigo, lista[i].descricao, lista[i].valor);
            }

            dgvServicos.Refresh();
        }

        internal ServicoVO preencherObjeto()
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text))
                _servicoVO.pk_codigo = Convert.ToInt32(txtCodigo.Text);
            _servicoVO.descricao = txtNome.Text;
            return _servicoVO;
        }

        private void preencheCbTipoServico()
        {
            TipoServicoBO _servicoBO = new TipoServicoBO();
            var list = _servicoBO.buscarTipoServico(new TipoServicoVO());
            list.Insert(0, new TipoServicoVO());
            cbTipoServico.DataSource = list;
            cbTipoServico.DisplayMember = "DESCRICAO";
            cbTipoServico.ValueMember = "DESCRICAO";
        }

        /// <summary>
        /// Método que habilita ou desabilita os componentes
        /// do formulário.
        /// </summary>
        /// Se flag for igual a true, os componentes são 
        /// habilitados, se for false, são desabilitados.
        /// <param name="flag"></param>
        private void habilitaComponentes(bool flag)
        {
            if (flag)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnGravar.Enabled = true;
                txtComissao.Enabled = true;
                txtCusto.Enabled = true;
                txtDescMaximo.Enabled = true;
                txtDuracao.Enabled = true;
                txtNome.Enabled = true;
                txtObs.Enabled = true;
                txtValor.Enabled = true;
                cbTipoServico.Enabled = true;
            }
            else
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnGravar.Enabled = false;
                txtComissao.Enabled = false;
                txtCusto.Enabled = false;
                txtDescMaximo.Enabled = false;
                txtDuracao.Enabled = false;
                txtNome.Enabled = false;
                txtObs.Enabled = false;
                txtValor.Enabled = false;
                cbTipoServico.Enabled = false;
            }
        }

#endregion

        private void Servico_Load(object sender, EventArgs e)
        {
            preencherDtgrid();
            preencheCbTipoServico();
            habilitaComponentes(false);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Dispose();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Preencha a DESCRICAO antes de gravar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _servicoVO.descricao = txtNome.Text;
                lista = _servicoBO.buscarServico(_servicoVO);

                if (lista.Count == 0)
                {
                    if (_servicoBO.gravarServico(preencherObjeto()))
                    {
                        MessageBox.Show("Descrição cadastrada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limparObjetos();

                        Servico_Load(null, null);
                        habilitaComponentes(false);
                    }
                }
                else
                {
                    MessageBox.Show("Descrição Inválida! Descrição ja cadastrada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Selecione uma descrição antes de alterar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _servicoBO.alterarServico(preencherObjeto());

            MessageBox.Show("Descrição alterada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Servico_Load(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Selecione uma descrição antes de excluir!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir esta Descrição?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            _servicoVO.pk_codigo = Convert.ToInt32(dgvServicos.Rows[dgvServicos.CurrentRow.Index].Cells[0].Value);

            _servicoBO.excluirServico(_servicoVO);

            MessageBox.Show("Descrição excluída com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Servico_Load(null, null);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaComponentes(true);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            habilitaComponentes(true);
        }


    }
}
