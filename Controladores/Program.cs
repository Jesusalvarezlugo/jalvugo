using jalvugo.Dtos;
using jalvugo.Servicios;

namespace jalvugo.Controladores
{
    /// <summary>
    /// Clase que controla el flujo de la aplicación
    /// jal-04/12/2023
    /// </summary>
    class Program
    {
        /// <summary>
        /// Clase por la que entra y sale el flujo de la aplicacion, donde se llaman a los metodos externos.
        /// jal-04/12/2023
        /// </summary>
        static void Main(string[] args)
        {
            List<VajillaDto> listaVajilla = new List<VajillaDto>();
            MenuInterfaz mi=new MenuImplementacion();
            OperativaInterfaz oi=new OperativaImplementacion();
            int opcionSeleccionada;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                mi.mostrarMensajeBienvenida();

                opcionSeleccionada = mi.mostrarMenuYSeleccion();

                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] Se cerrara el menú");
                        cerrarMenu=true;    
                        break;

                    case 1:
                        Console.WriteLine("[INFO] Se dara de alta un nuevo elemento");

                        oi.darAltaElemento(listaVajilla);

                        foreach(VajillaDto vajilla in listaVajilla)
                        {
                            Console.WriteLine(vajilla.ToString());
                        }
                        break;

                    case 2:
                        Console.WriteLine("[INFO] Se eliminara cierta  cantidad del elemento ");

                        oi.eliminarCantidadElemento(listaVajilla);

                        foreach(VajillaDto vijilla in listaVajilla)
                        {
                            Console.WriteLine(vijilla.ToString());  
                        }
                        break;
                }
            }
        }
    }
}
