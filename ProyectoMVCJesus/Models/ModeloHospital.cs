using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoMVCJesus.Models
{
    public class ModeloHospital
    {
        ContextoHospital contexto;

        public ModeloHospital()
        {
            this.contexto = new ContextoHospital();
        }

        public List<EMP> GetEmpleados()
        {
            var consulta = from datos in contexto.EMP
                           select datos;
            return consulta.ToList();
        }
    }
}