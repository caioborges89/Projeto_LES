using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BeautySys.Util;
using BeautySys.Classes;
using BeautySys.DataAccess.Util;

namespace BeautySys.DataAccess
{
    class ProdutoDA
    {
        Funcoes _funcoes = new Funcoes();

        /// <summary>
        /// Método que faz a gravação dos dados do produto
        /// no banco de dados.
        /// </summary>
        /// <param name="produtoVO"></param>
        /// <returns></returns>
        public bool gravarProduto(ProdutoVO produtoVO)
        {
            try
            {
                string sql = @"INSERT INTO PRODUTO(PK_CODIGO,DESCRICAO,FK_TIPO_DESCRICAO,
                          FK_MEDIDA,QTDE_ESTOQUE,ESTOQUE_MINIMO,VALOR,CUSTO,DESC_MAX,COMISSAO,OBS)
                          VALUES(@PK_CODIGO,@DESCRICAO,@FK_TIPO_DESCRICAO,@FK_MEDIDA,@QTDE_ESTOQUE,
                          @ESTOQUE_MINIMO,@VALOR,@CUSTO,@DESC_MAX,@COMISSAO,@OBS)";

                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("PRODUTO", "PK_CODIGO");
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = produtoVO.descricao;
                cmd.Parameters.Add("@FK_TIPO_DESCRICAO", SqlDbType.Int).Value = produtoVO.fk_tipo_produto;
                cmd.Parameters.Add("@FK_MEDIDA", SqlDbType.VarChar).Value = produtoVO.fk_medida;
                cmd.Parameters.Add("@QTDE_ESTOQUE", SqlDbType.Decimal).Value = produtoVO.qtde_estoque;
                cmd.Parameters.Add("@ESTOQUE_MINIMO", SqlDbType.Int).Value = produtoVO.estoque_minimo;
                cmd.Parameters.Add("@VALOR", SqlDbType.Decimal).Value = produtoVO.valor;
                cmd.Parameters.Add("@CUSTO", SqlDbType.Decimal).Value = produtoVO.custo;
                cmd.Parameters.Add("@DESC_MAX", SqlDbType.Decimal).Value = produtoVO.desc_max;
                cmd.Parameters.Add("@COMISSAO", SqlDbType.Decimal).Value = produtoVO.comissao;
                cmd.Parameters.Add("@OBS", SqlDbType.NVarChar).Value = produtoVO.obs;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
    }
}
