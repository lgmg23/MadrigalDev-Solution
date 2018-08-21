using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadrigalDev_Model.EmpresaModel
{
    public class DetalleEmpresaModel
    {
        public int IdDetalleEmpresa { get; set; }
        public string Domicilio { get; set; }
        public string Correo { get; set; }
        public virtual EmpresaModel Empresa { get; set; }
    }
}
