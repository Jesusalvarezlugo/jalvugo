using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jalvugo.Dtos;

namespace jalvugo.Servicios
{
    /// <summary>
    /// Interfaz que relaciona con la implementacion de la operativa.
    /// jal-04/12/2023
    /// </summary>
    internal interface OperativaInterfaz
    {

        /// <summary>
        /// Método con el cual añadimos un elemento.
        /// jal-04/12/2023
        /// </summary>
        public void darAltaElemento(List<VajillaDto> listaAntigua);


        /// <summary>
        /// Método con el cual restamos cantidad del elemento.
        /// jal-04/12/2023
        /// </summary>
        public void eliminarCantidadElemento(List<VajillaDto> listaAntigua);
    }
}
