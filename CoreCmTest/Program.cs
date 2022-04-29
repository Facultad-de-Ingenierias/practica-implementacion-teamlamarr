using L01_Application;
using L01_Domain.Paciente;
using L02_Persistence;
using System;
using System.IO;

namespace CoreCmTest
{
    class Program
    {
        static void Main()
        {
            /* Test the JSON generetion */
            //FakeDB.TablaPacientes.InstanciarPacientes(10);
            //String s = FakeDB.TablaPacientes.ToJSON();
            //Console.WriteLine(s);



            /* Test Persistence */
            //try
            //{
            //    RepositorioPacientesFake repoP = new RepositorioPacientesFake();
            //    IPacienteCita p = repoP.GetPaciente(10008);

            //    Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(p));

            //}
            //catch (PacienteNoEncontradoException ex)
            //{
            //    Console.WriteLine("ERROR-->" + ex.Message);
            //}


            /* Test Architecture */

            try
            {
                CtrlAsignarCita ctrl = new CtrlAsignarCita();
                //Console.WriteLine(ctrl.BuscarPaciente("10008"));
                Console.WriteLine(ctrl.BuscarPaciente("11118"));
            }
            catch (PacienteNoEncontradoException ex)
            {
                Console.WriteLine("ERROR-->" + ex.Message);
            }



            Console.ReadLine();
        }
    }
}
