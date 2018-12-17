using LCCDS.Csharp.Dominio.Entidade;
using LCCDS.Csharp.Dominio.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LCCDS.Csharp.Web.Forms
{
    public partial class CadPessoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { }
        }
       

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Pessoa pessoa = new Pessoa();
                Endereco endereco = new Endereco();
                pessoa.Nome = txtNome.Text.Trim();
                pessoa.Endereco = endereco;
                pessoa.Documentos = AdicionarDocumentosPessoa();
                

            }
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Form.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
        }

        protected List<Documento> AdicionarDocumentosPessoa()
        {
            List<Documento> lstDocumentos = new List<Documento>();
            return lstDocumentos;
        }
    }
}