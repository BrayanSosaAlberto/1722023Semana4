using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsincronaSemana4.entidades;

namespace AsincronaSemana4.negocio

{
    public class ClsNegocioDeConteo
    {

      public int ContarLetras(EntidadDeConteo entidad)
      {
        return entidad.Texto.Length;
      }  
    }
}