using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
             
            empleado empleado = new empleado ("patricio", "estrella", 23,  "despachador", 500 );
            empleado.setnombre("bob");
            empleado.setapellido("esponja");
            empleado.setedad(21);
            empleado.setdepartamento("vendedor");
            empleado.imprimiendoempleado();
            Console.WriteLine("\nNombre: " + empleado.getnombre() + "\nApellido " + empleado.getapellido() + " \nEdad "
                + empleado.getedad() + "\nDepartamento:" + empleado.getdepartamento());           

            empleadoporhoras empleadoporhoras = new empleadoporhoras("julio", "rodriguez", 35, "contador", 600);
            empleadoporhoras.setnombre("arenita");
            empleadoporhoras.setapellido("loor");
            empleadoporhoras.sethorasquetrabajo(15);
            empleadoporhoras.imprimirempleadoporhoras();
            empleadoporhoras.setdepartamento("contador");
            Console.WriteLine("\nNombre: " + empleadoporhoras.getnombre() + "\nApellido " + empleadoporhoras.getapellido() + "\nEdad: "
                + empleadoporhoras.getedad() + "\nDepartamento: " + empleadoporhoras.getdepartamento());


            empleadofijo empleadofijo = new empleadofijo("tina", "zuares", 34, "conductor", 500, 2020);
            empleadofijo.imprimirdatosempleadofijo();
            empleadofijo.setdepartamento("conductor");
            Console.WriteLine("\nDepartamento: " + empleadofijo.getdepartamento());



            empleadotemporal empleadotemporal = new empleadotemporal("karla", "tomala", 18, "administradora", 500);
            empleadotemporal.setnombre("maria");
            empleadotemporal.setapellido("briones");
            empleadotemporal.setedad(22);
            Console.WriteLine("\nSueldoDeTemporada " + empleadotemporal.getsueldo());

        }
    }
}
