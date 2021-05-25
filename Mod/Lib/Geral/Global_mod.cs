using System;
using System.Configuration;


namespace Mod.Lib.Geral
{


    public class Global_mod 
    {
        public static string GetConnectString()
        {
           return ConfigurationManager.ConnectionStrings["Conneu"].ConnectionString;           
        }

        public static String ValidaCaracteres(String texto)
        {
            var retorno = texto;
            if (texto != null)
            {
                retorno = retorno.Replace("ã", "a").Replace("â", "a").Replace("á", "a").Replace("à", "a").Replace("ä", "a");
                retorno = retorno.Replace("Ã", "A").Replace("Â", "A").Replace("À", "A").Replace("Ä", "A").Replace("Á", "A");
                retorno = retorno.Replace("õ", "o").Replace("ô", "o").Replace("ó", "o").Replace("ò", "o").Replace("ö", "o");
                retorno = retorno.Replace("Õ", "O").Replace("Ô", "O").Replace("Ó", "O").Replace("Ò", "O").Replace("Ö", "O");
                retorno = retorno.Replace("ê", "e").Replace("é", "e").Replace("è", "e").Replace("ë", "e");
                retorno = retorno.Replace("î", "i").Replace("í", "i").Replace("ì", "i").Replace("ï", "i");
                retorno = retorno.Replace("û", "u").Replace("ú", "u").Replace("ù", "u").Replace("ü", "u");
                retorno = retorno.Replace("ç", "c").Replace("Ç", "C");
                retorno = retorno.Replace("Ê", "E").Replace("É", "E").Replace("È", "E").Replace("Ë", "E");
                retorno = retorno.Replace("Î", "I").Replace("Í", "I").Replace("Ì", "I").Replace("Ï", "I");
                retorno = retorno.Replace("Û", "U").Replace("Ú", "U").Replace("Ù", "U").Replace("Ü", "U");
                retorno = retorno.Replace("º", "O").Replace("ª", "A");
            }
            else
                retorno = string.Empty;

            return retorno;
        }

        public static void MostraMensagemTela(System.Web.UI.Page pagina, string mensagem)
        {
            pagina.ClientScript.RegisterClientScriptBlock(typeof(System.Web.UI.Page), "Alerta", "alert('" + mensagem.Replace("'", " ").Replace("\n", "").Replace("\r", "") + "');", true);
        }

    }
}
