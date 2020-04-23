using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.COMMON.Entidades
{
    class Material:Base

    {
        public string Nombre { get; set; }
       
        public int MyProperty { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
    }
}
