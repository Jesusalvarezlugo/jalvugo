using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jalvugo.Servicios
{
    /// <summary>
    /// Interfaz que relaciona la implementacion del menu
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Muestra el mensaje de bienvenida a la aplicacion
        /// jal-04/12/2023
        /// </summary>
        public void mostrarMensajeBienvenida();

        /// <summary>
        /// Muestra el menu y recoge la opcion seleccionada por el usuario
        /// jal-04/12/2023
        /// </summary>
        /// <returns>opcion del menú</returns>
        public int mostrarMenuYSeleccion();

        /// <summary>
        /// Método que utilizamos para identificar el elemento.
        /// </summary>
        /// <returns>codigo del elemento para identificar</returns>
        public string pedirCodigoElemento();
    }
}
