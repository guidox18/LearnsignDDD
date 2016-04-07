using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSolucion.Dominio.Entidades
{
    public class Cargo
    {
        public string IDCargo { get; set; }
        public string TituloCargo { get; set; }
        public int SalarioMinimo { get; set; }
        public int SalarioMaximo { get; set; }
    }
}
