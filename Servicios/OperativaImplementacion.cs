using jalvugo.Dtos;
using jalvugo.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace jalvugo.Servicios
{

    /// <summary>
    /// Clase que implementa la interfaz y la cual tiene la logica.
    /// jal-04/12/2023
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void darAltaElemento(List<VajillaDto> listaAntigua)
        {
            VajillaDto nuevoElemento = crearElemento();

            listaAntigua.Add(nuevoElemento);
        }


        /// <summary>
        /// Método para crear un nuevo elemento.
        /// jal-04/12/2023
        /// </summary>
        private VajillaDto crearElemento()
        {
            VajillaDto elementoVajilla= new VajillaDto();

            Console.WriteLine("Introduce el ID del elemento: ");
            elementoVajilla.IdElemento=Int64.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el nombre del elemento: ");
            elementoVajilla.NombreElemento = Console.ReadLine();

            elementoVajilla.CodigoElemento = elementoVajilla.IdElemento + elementoVajilla.NombreElemento;

            Console.WriteLine("Introduzca la descripcion del elemento: ");
            elementoVajilla.DescripcionElemento = Console.ReadLine();

            Console.WriteLine("Introduzca la cantidad del elemento: ");
            elementoVajilla.CantidadElemento=Int32.Parse(Console.ReadLine());

            return elementoVajilla;
        }

        public void eliminarCantidadElemento(List<VajillaDto> listaAntigua)
        {
            string cantidadABuscar;
            MenuInterfaz mi = new MenuImplementacion();
            int cantidadEliminar;

            cantidadABuscar = mi.pedirCodigoElemento();

            foreach(VajillaDto vajilla in listaAntigua)
            {
                if (vajilla.CodigoElemento.Equals(cantidadABuscar))
                {
                    Console.WriteLine("Indique que cantidad desea eliminar: ");
                    cantidadEliminar=Int32.Parse(Console.ReadLine());

                    vajilla.CantidadElemento = vajilla.CantidadElemento - cantidadEliminar;
                    break;

                }

                
            }

            Console.WriteLine("Dicho elemento no existe");

        }
    }
}
