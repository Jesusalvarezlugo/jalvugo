using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jalvugo.Servicios
{

    /// <summary>
    /// Clase que contiene el menu, mensaje y el metodo para identificar un elemento
    /// jal-04/12/2023
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mostrarMensajeBienvenida()
        {
            string mensaje="Bienvenido/a al control de stock de nuestro catering.";

            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {
            int opcion;

            Console.WriteLine("###################");
            Console.WriteLine("0. Cerrar Menú");
            Console.WriteLine("1. Dar de alta un elemento");
            Console.WriteLine("2. eliminar cierta cantidad de un elemento");
            Console.WriteLine("###################");
            Console.WriteLine("Introduzca una opcion: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }

        public string pedirCodigoElemento()
        {
            string codigoABuscar;

            Console.WriteLine("Introduzca el codigo del elemento: ");
            codigoABuscar = Console.ReadLine();

            return codigoABuscar;
        }
    }
}
