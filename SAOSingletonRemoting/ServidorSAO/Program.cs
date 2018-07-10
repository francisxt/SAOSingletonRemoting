using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using ComponenteSAOST;

/********************************
*  Aplicaciones Distribuidas   *
*  Francisco Gualli            *
*  Gr1                         *
*  Practica 05                 *
*  ServidorSAO                 *
/*******************************/
//Lance otro ClienteSAO (puede ir a la carpeta Debug, buscar el ejecutable y presionar doble
//clic). Cuál es el resultado?

//Se puede ejecutar multiples clientes simultaneamente.

//Explique claramente cuál es la diferencia entre Singleton y SingleCall

//Singleton usa el mismo objeto para todas las llamadas del cliente y singlecall usa un objeto diferente.
namespace ServidorSAO
{

    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("ServidorSAO.exe.config");
            Utilidades.MostrarTodosLosDatos();
            Log.EsperarParaTerminar("Presione ENTER para detener al servidor...");
        }
    }
}

