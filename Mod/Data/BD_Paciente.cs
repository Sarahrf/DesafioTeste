using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using MySql.Data.MySqlClient;

namespace Mod.Data
{
    class BD_Paciente
    {
        MySqlConnection bdConn = new MySqlConnection(); //MySQL

        public DataTable ConsultarCPF(string vstr)
        {

            DataTable dt = new DataTable();
                       
           
            bdConn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conneu"].ConnectionString;
            MySqlCommand bdCmd = new MySqlCommand("sp_select", bdConn);
            bdCmd.CommandType = CommandType.StoredProcedure;
            
            try
            {
                bdConn.Open();

                bdCmd.Parameters.Clear();
                bdCmd.Parameters.AddWithValue("iCPF", vstr);
                MySqlDataReader dr = bdCmd.ExecuteReader();


                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                ds.EnforceConstraints = false;
                dt.Load(dr);

                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro " + ex.Message);
            }
            finally
            {
                bdCmd.Parameters.Clear();
                bdConn.Dispose();
            }

        }



        public Boolean GravarDadosPaciente(Mod.Entity.Cl_Paciente dados)
        {

            MySqlCommand bdCmd = new MySqlCommand();

            bdConn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conneu"].ConnectionString;
            
            bdCmd = new MySqlCommand("sp_insere", bdConn);
            bdCmd.CommandType = CommandType.StoredProcedure;

            try
            {
                bdConn.Open();

                bdCmd.Parameters.Clear();
                bdCmd.Parameters.AddWithValue("iprontuario", dados.prontuario);
                bdCmd.Parameters.AddWithValue("inome", dados.nome);
                bdCmd.Parameters.AddWithValue("isobrenome", dados.sobrenome);
                bdCmd.Parameters.AddWithValue("idata_nasc", dados.dt_nasc);
                bdCmd.Parameters.AddWithValue("igenero", dados.genero);
                bdCmd.Parameters.AddWithValue("iCPF", dados.CPF);
                bdCmd.Parameters.AddWithValue("iRG", dados.RG);
                bdCmd.Parameters.AddWithValue("iUF_RG", dados.UFRG);
                bdCmd.Parameters.AddWithValue("iemail", dados.email);
                bdCmd.Parameters.AddWithValue("icelular", dados.celular);
                bdCmd.Parameters.AddWithValue("itelefone", dados.telefone);
                bdCmd.Parameters.AddWithValue("iconvenio", dados.convenio);
                bdCmd.Parameters.AddWithValue("iid_convenio", dados.carteirinha_conv);
                bdCmd.Parameters.AddWithValue("ivalid_convenio", Convert.ToDateTime(dados.validadecart));
                bdCmd.ExecuteNonQuery();
                                
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro " + ex.Message);
            }
            finally
            {
                bdCmd.Parameters.Clear();
                bdConn.Dispose();
            }

        }


        public Boolean AlterarDadosPaciente(Mod.Entity.Cl_Paciente dados)
        {

            MySqlCommand bdCmd = new MySqlCommand();

            bdConn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conneu"].ConnectionString;
            bdCmd = new MySqlCommand("sp_altera", bdConn);
            bdCmd.CommandType = CommandType.StoredProcedure;

            try
            {
                bdConn.Open();

                bdCmd.Parameters.Clear();
                bdCmd.Parameters.AddWithValue("iprontuario", dados.prontuario);
                bdCmd.Parameters.AddWithValue("inome", dados.nome);
                bdCmd.Parameters.AddWithValue("isobrenome", dados.sobrenome);
                bdCmd.Parameters.AddWithValue("idata_nasc", Convert.ToString(dados.dt_nasc));
                bdCmd.Parameters.AddWithValue("igenero", dados.genero);
                bdCmd.Parameters.AddWithValue("iCPF", dados.CPF);
                bdCmd.Parameters.AddWithValue("iRG", dados.RG);
                bdCmd.Parameters.AddWithValue("iUF_RG", dados.UFRG);
                bdCmd.Parameters.AddWithValue("iemail", dados.email);
                bdCmd.Parameters.AddWithValue("icelular", dados.celular);
                bdCmd.Parameters.AddWithValue("itelefone", dados.telefone);
                bdCmd.Parameters.AddWithValue("iconvenio", dados.convenio);
                bdCmd.Parameters.AddWithValue("iid_convenio", dados.carteirinha_conv);
                bdCmd.Parameters.AddWithValue("ivalid_convenio", Convert.ToDateTime(dados.validadecart));
                bdCmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro " + ex.Message);
            }
            finally
            {
                bdCmd.Parameters.Clear();
                bdConn.Dispose();
            }

        }

    }
}
