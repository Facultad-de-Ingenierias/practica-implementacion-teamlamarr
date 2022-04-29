using System;
using System.Collections.Generic;

using System.Text;

namespace L01_Domain.Especialidad
{
    public class Especialidad
        {
        /// <summary>
        /// Constructor
        /// </summary>
        public Especialidad() {
            Guid g = Guid.NewGuid();   // Genera un codigo Unico
            especialidadId = g.ToString();
        }
        /// <summary>
        /// Atributos y Propiedades
        /// </summary>
        private readonly string especialidadId;
        public string EspecialidadId
        {
            get { return especialidadId; }
    
            }
        public string EspecialidadDesc { get; set; }

    }
    



    }

