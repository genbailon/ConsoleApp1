using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoEmpleados
{
    
    class empleadofijo : empleado
    {

        public int añodeentrada { get; set; }
      

    public empleadofijo(string nombre, string apellido, int edad, string departamento, int sueldo, int añodeentrada) : base(nombre, apellido, edad,departamento, sueldo) 
        {
            this.añodeentrada = añodeentrada;
            this.sueldo = sueldo;

        }


        public int getañodeentrada () 
        {
            return añodeentrada;
        }
        public void setañodeentrada(int añodeentrada) 
        {
            this.añodeentrada = añodeentrada;
        }


        public void imprimirdatosempleadofijo() 
        {
            Console.WriteLine("\nNombre del empleado: " + getnombre() + "\nApellido: " + getapellido() + "\nEdad: " + getedad() + "\nAño de entrada: " + añodeentrada  );
        }


    }
}

