using Mod.Data;
using System;
using System.Data;

namespace Mod.Lib.Bll
{
    public class Bll_Paciente
    {
        public DataTable ConsultarCPF(string vtexto)
        {
            return new BD_Paciente().ConsultarCPF(vtexto);
        }

        public Boolean SalvarPaciente(Mod.Entity.Cl_Paciente dados)
        {
            return new BD_Paciente().GravarDadosPaciente(dados);
        }

        public Boolean AlterarPaciente(Mod.Entity.Cl_Paciente dados)
        {
            return new BD_Paciente().AlterarDadosPaciente(dados);
        }

    }
}
