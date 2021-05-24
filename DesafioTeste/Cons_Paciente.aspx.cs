using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

using Mod.Lib;
using Mod.Lib.Bll;
using Mod.Lib.Geral;


namespace DesafioTeste
{
    public partial class Cons_Paciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LimpaCampos();
            DivAcao(divpesq, divdados);
            botoes(false);
        }

        public void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();            
            DivAcao(divpesq, divdados);
            botoes(false);
        }

        public void btnConsultarCPF_Click(object sender, EventArgs e)
        {

            if (txtpesqcpf.Value != "")
            {
                botoes(false);
                DivAcao(divdados, divpesq);
                LimpaCampos();

                var bll = new Mod.Lib.Bll.Bll_Paciente();

                DataTable DtRet = bll.ConsultarCPF(txtpesqcpf.Value);

                if (DtRet != null)
                {
                    dtAtualizarPagina(DtRet);
                    botoes(true);
                }
                else
                {
                    Mod.Lib.Geral.Global_mod.MostraMensagemTela(this.Page, "Paciente não foi localizado.");
                    DivAcao(divpesq, divdados);
                    botoes(false); 
                }
            }
            else
            { 
                Mod.Lib.Geral.Global_mod.MostraMensagemTela(this.Page, "Favor informar um cpf para pesquisa.");
                DivAcao(divpesq, divdados);
                botoes(false);
            }
        }


        public void btnAlterar_Click(object sender, EventArgs e)
        {

            if (txtpesqcpf.Value != "")
            {               
                DivAcao(divdados, divpesq);
                
                var bll = new Mod.Lib.Bll.Bll_Paciente();
                DataTable DtRet = bll.ConsultarCPF(txtpesqcpf.Value);

                if (DtRet.Rows.Count ==1)
                {
                    txtpesqcpf.Value = "";
                    botoes(true);

                    Mod.Entity.Cl_Paciente clDados = carregadados();

                    Boolean ret = bll.AlterarPaciente(clDados);
                    if (ret)
                    {
                        Mod.Lib.Geral.Global_mod.MostraMensagemTela(this.Page, "Dados atualizados.");
                        botoes(true);
                    }
                    else
                    {
                        Mod.Lib.Geral.Global_mod.MostraMensagemTela(this.Page, "Houveram problemas ao salvar os dados do paciente.");
                        botoes(false);
                    }
                }
                else
                {
                    Mod.Lib.Geral.Global_mod.MostraMensagemTela(this.Page, "Paciente não foi localizado.");
                    DivAcao(divpesq, divdados);
                    botoes(false);
                }
            }
        }

        //metodos
        public void LimpaCampos()
        {
            txtprontuario.Value = "";
            txtnome.Value = "";
            txtsobrenome.Value = "";
            txtdt_nasc.Value = "";
            cbogenero.Value = "";
            txtcpf.Value = "";
            txtrg.Value = "";
            cboufrg.Value = "";
            txtemail.Value = "";
            txtcel.Value = "";
            txttel.Value = "";
            txtconvenio.Value = "";
            txtcarteirinha.Value = "";
            txtval_cart.Value = "";
        }


        private void DivAcao(HtmlGenericControl divExibir, HtmlGenericControl divOcultar)
        {
            divExibir.Visible = true;
            divOcultar.Visible = false;
        }

        private void botoes(Boolean status)
        {
            btnLimpar.Visible = status;
            btnAlterar.Visible = status;
        }
        public void dtAtualizarPagina(DataTable dtret)
        {
            string vstr;

            foreach (DataRow dw in dtret.Rows)
            {
                txtprontuario.Value = dw["prontuario"].ToString();
                txtnome.Value = dw["nome"].ToString();
                txtsobrenome.Value = dw["sobrenome"].ToString();
                txtdt_nasc.Value = Convert.ToString(dw["data_nasc"]);
                cbogenero.Value = dw["genero"].ToString();
                txtcpf.Value = dw["CPF"].ToString();
                txtrg.Value = dw["RG"].ToString();
                cboufrg.Value = dw["UF_RG"].ToString();
                txtemail.Value = dw["email"].ToString();
                txtcel.Value = dw["celular"].ToString();
                txttel.Value = dw["telefone"].ToString();
                txtconvenio.Value = dw["convenio"].ToString();
                txtcarteirinha.Value = dw["id_convenio"].ToString();
                txtval_cart.Value = dw["valid_convenio"].ToString();
            }
        }

        public Mod.Entity.Cl_Paciente carregadados()
        {

            var clRev = new Mod.Entity.Cl_Paciente();

            clRev.prontuario =Global_mod.ValidaCaracteres(txtprontuario.ToString());
            clRev.nome = Global_mod.ValidaCaracteres(txtnome.ToString());
            clRev.sobrenome = Global_mod.ValidaCaracteres(txtsobrenome.ToString());
            clRev.dt_nasc= Convert.ToDateTime(txtdt_nasc.ToString());
            clRev.genero= cbogenero.ToString();
            clRev.CPF= txtcpf.ToString();
            clRev.RG= txtrg.ToString();
            clRev.UFRG= cboufrg.ToString();
            clRev.email= Global_mod.ValidaCaracteres(txtemail.ToString());
            clRev.celular= txtcel.ToString();
            clRev.telefone= txttel.ToString();
            clRev.convenio= Global_mod.ValidaCaracteres(txtconvenio.ToString());
            
            if (txtcarteirinha.Value != "")
            {
                if (Convert.ToInt32(txtcarteirinha.Value) > 0)
                {
                    clRev.carteirinha_conv = Convert.ToInt32(txtcarteirinha.ToString());
                }
            }

            clRev.validadecart = txtval_cart.ToString();

            return clRev;

        }

    }
}