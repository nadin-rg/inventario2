using Inventario.COMMON.Interfaces;
using Inventario.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.DAL
{
    public class RepositorioDeEmpleado : IRepositorio1<Empleado>
    {
        public List<Empleado> Read => throw new NotImplementedException();

        public bool Creat(Empleado entidad)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Empleado entidad)
        {
            throw new NotImplementedException();
        }

        public bool Update(Empleado entidadOriginal, Empleado entidadModificada)
        {
            throw new NotImplementedException();
        }
    }
}
