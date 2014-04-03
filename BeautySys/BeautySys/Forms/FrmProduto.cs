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
    public partial class FrmProduto : Form
    {
        List<ProdutoVO> lista = new List<ProdutoVO>();
        ProdutoBO _produtoBO = new ProdutoBO();
        ProdutoVO _produtoVO = new ProdutoVO();

        public FrmProduto()
        {
            InitializeComponent();
        }

#region "Métodos"

        private void limparObjetos()
        {
        }

        private void preencherDtgrid()
        {
            limparObjetos();

            lista = _produtoBO.buscarProduto(new ProdutoVO());

            DgvCadProdutos.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                DgvCadProdutos.Rows.Add(lista[i].pk_codigo, lista[i].descricao, lista[i].qtde_estoque, lista[i].valor);
            }
        }
#endregion


        private void Produto_Load(object sender, EventArgs e)
        {
            preencherDtgrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Dispose();
        }
    }
}
