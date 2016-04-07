using System;
using System.Collections.Generic;
using System.Linq;

namespace HRSolucion.Dominio.Entidades
{
    public class Empleado
    {
        public int IDEmpleado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string CorreoElectronico { get; set; }
        public string NumeroTelefono { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string IDCargo { get; set; }
        public decimal Salario { get; set; }
        public decimal PorcentajeComision { get; set; }
        public int? IDAdministrador { get; set; }
        public int? IDDepartamento { get; set; }
        public virtual Cargo Cargo { get; set; }
        public virtual Departamento Departamento { get; set; }
    }
}
