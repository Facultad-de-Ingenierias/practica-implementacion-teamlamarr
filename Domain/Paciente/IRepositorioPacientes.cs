using L01_Domain.Especialidad;
using L01_Domain.Paciente;
using System;
using System.Collections.Generic;
using System.Text;

namespace L01_Domain.Paciente
{
    public interface IRepositorioPacientes
    {
        IPacienteCita GetPaciente(int idPaciente);
        

    }
}
