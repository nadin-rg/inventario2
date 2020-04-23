using Inventario.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.COMMON.Interfaces
{
    public interface IRepositorio1<T> where
        T:Base
    {
        bool Creat(T entidad);
        List<T> Read { get; }
        bool Update(string ID, T entidadModificada);
        bool Delete(T entidad);
       
    }
}
