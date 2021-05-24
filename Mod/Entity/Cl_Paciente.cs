using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod.Entity
{
    public class Cl_Paciente
    {
        string _prontuario;
        string _nome;
        string _sobrenome;
        DateTime _dt_nasc;
        string _genero;
        string _CPF;
        string _RG;
        string _UFRG;
        string _email;
        string _celular;
        string _telefone;
        string _convenio;
        int _carteirinha_conv;
        string _validadecart;

        public string prontuario
        {
            get
            {
                return _prontuario;
            }
            set
            {
                _prontuario = value;
            }
        }
        public string nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        public string sobrenome
        {
            get
            {
                return _sobrenome;
            }
            set
            {
                _sobrenome = value;
            }
        }
        public DateTime dt_nasc
        {
            get
            {
                return _dt_nasc;
            }
            set
            {
                _dt_nasc = value;
            }
        }
        public string genero
        {
            get
            {
                return _genero;
            }
            set
            {
                _genero = value;
            }
        }
        public string CPF
        {
            get
            {
                return _CPF;
            }
            set
            {
                _CPF = value;
            }
        }
        public string RG
        {
            get
            {
                return _RG;
            }
            set
            {
                _RG = value;
            }
        }
        public string UFRG
        {
            get
            {
                return _UFRG;
            }
            set
            {
                _UFRG = value;
            }
        }
        public string email 
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public string celular
        {
            get
            {
                return _celular;
            }
            set
            {
                _celular = value;
            }
        }
        public string telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                _telefone = value;
            }
        }
        public string convenio
        {
            get
            {
                return _convenio;
            }
            set
            {
                _convenio = value;
            }
        }
        public int carteirinha_conv
        {
            get
            {
                return _carteirinha_conv;
            }
            set
            {
                _carteirinha_conv = value;
            }
        }
        public string validadecart
        {
            get
            {
                return _validadecart;
            }
            set
            {
                _validadecart = value;
            }
        }
                               
    }
}
