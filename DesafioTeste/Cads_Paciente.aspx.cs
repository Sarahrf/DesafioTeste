using Mod.Lib.Geral;
using System;
using System.Data;


namespace DesafioTeste
{
    public partial class Cads_Paciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        public void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        public void btnSalvar_Click(object sender, EventArgs e)
        {
            txtcadcpf.Value = "29073548845";
            if (txtcadcpf.Value != "")
            {
                var bll = new Mod.Lib.Bll.Bll_Paciente();

                DataTable DtRet = bll.ConsultarCPF(txtcadcpf.Value);

                if (DtRet.Rows.Count == 0)
                {
                    Mod.Entity.Cl_Paciente clDados = carregadados();

                    if (bll.SalvarPaciente(clDados))
                    {
                        Mod.Lib.Geral.Global_mod.MostraMensagemTela(this.Page, "Dados atualizados.");
                    }
                    else
                    {
                        Mod.Lib.Geral.Global_mod.MostraMensagemTela(this.Page, "Houveram problemas ao salvar os dados do paciente.");
                    }
                }
                else
                {
                    Mod.Lib.Geral.Global_mod.MostraMensagemTela(this.Page, "Paciente não cadastrado.");
                }
            }
            else
            {
                Mod.Lib.Geral.Global_mod.MostraMensagemTela(this.Page, "Favor informar um cpf valido.");
            }
        }


        //metodos

        public void LimpaCampos()
        {
            txtcadprontuario.Value = "";
            txtcadnome.Value = "";
            txtcadsobrenome.Value = "";
            txtcaddt_nasc.Value = "";
            cbogenero.Value = "";
            txtcadcpf.Value = "";
            txtcadrg.Value = "";
            cboufrg.Value = "";
            txtcademail.Value = "";
            txtcadcel.Value = "";
            txtcadtel.Value = "";
            txtcadconvenio.Value = "";
            txtcadcarteirinha.Value = "";
            txtcadval_cart.Value = "";
        }


        public Mod.Entity.Cl_Paciente carregadados()
        {

            var clRev = new Mod.Entity.Cl_Paciente();

            clRev.prontuario = Global_mod.ValidaCaracteres(txtcadprontuario.ToString());
            clRev.nome = Global_mod.ValidaCaracteres(txtcadnome.ToString());
            clRev.sobrenome = Global_mod.ValidaCaracteres(txtcadsobrenome.ToString());
            clRev.dt_nasc = Convert.ToDateTime(txtcaddt_nasc.ToString());
            clRev.genero = cbogenero.ToString();
            clRev.CPF = txtcadcpf.ToString();
            clRev.RG = txtcadrg.ToString();
            clRev.UFRG = cboufrg.ToString();
            clRev.email = Global_mod.ValidaCaracteres(txtcademail.ToString());
            clRev.celular = txtcadcel.ToString();

            if (txtcadtel.ToString() != "")
            {
                clRev.telefone = txtcadtel.ToString();
            }
            if (txtcadconvenio.ToString() != "")
            {
                clRev.convenio = Global_mod.ValidaCaracteres(txtcadconvenio.ToString());
            }

            if (txtcadcarteirinha.Value != "")
            {
                if (Convert.ToInt32(txtcadcarteirinha.Value) > 0)
                {
                    clRev.carteirinha_conv = Convert.ToInt32(txtcadcarteirinha.ToString());
                }
            }
            if (txtcadval_cart.ToString() != "")
            {
                clRev.validadecart = txtcadval_cart.ToString();
            }
            return clRev;

        }
    }
}