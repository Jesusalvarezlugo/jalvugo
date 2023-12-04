using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jalvugo.Dtos
{
    /// <summary>
    /// Clase de la entidad Vajilla.
    /// jal-04/12/2023
    /// </summary>
    internal class VajillaDto
    {

        //Atributos

        long idElemento=0;
        string codigoElemento="aaaaa";
        string nombreElemento="aaaaa";
        string descripcionElemento = "aaaaa";
        int cantidadElemento = 0;

        

        //Getters y Setters
        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }

        //Constructores

        public VajillaDto()
        {

        }

        public VajillaDto(long idElemento, string codigoElemento, string nombreElemento, string descripcionElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.codigoElemento = codigoElemento;
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }

        //Método ToString
        /// <summary>
        /// Método para mostrar los campos de la entidad Vajilla
        /// jal-04/12/2023
        /// </summary>
        /// <returns></returns>

        override
        public string ToString()
        {
            /* string texto ="IdElemento: "+this.idElemento+"\n CodigoElemento: "+this.codigoElemento+
                 "\n NombreElemento:  "+this.nombreElemento+"\n DescripcionElemento: "+this.descripcionElemento+
                 "\n CantidadElemento: "+this.cantidadElemento;*/

            string texto = "\n NombreElemento: " + this.nombreElemento + "\n CantidadElemento: " + cantidadElemento;

            return texto;
        }
    }
}
