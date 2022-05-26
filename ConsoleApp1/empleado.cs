using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoEmpleados
{

   public class empleado
    {

        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string departamento { get; set; }
        public  int sueldo { get; set; }

        public empleado ( string nombre, string apellido, int edad,  string departamento, int sueldo ) //instanciar 
        {
           this.nombre = nombre;
           this.apellido = apellido;
           this.edad = edad;
           this.departamento = departamento;
           this.sueldo = 500; 
        }

    
        public void imprimiendoempleado() 
        {
            Console.WriteLine( "Nombre: " + nombre + "Apellido: " + apellido + "Edad: " + edad + "Departamento: " + departamento + "Sueldo: " + sueldo);
        }





        public string getnombre() 
        {
            return nombre;
        }
        public void setnombre(string nombre) 
        {
            this.nombre = nombre;
        }

        public string getapellido()
        {
            return apellido;
        }
        public void setapellido(string apellido)
        {
            this.apellido = apellido;
        }

        public int getedad()
        {
            return edad;
        }
        public void setedad(int edad)
        {
            this.edad = edad;
        }

        public string getdepartamento()
        {
            return departamento;
        }
        public void setdepartamento(string departamento)
        {
            this.departamento = departamento;
        }

       public int getsueldo()
        {
            return sueldo;
        }
        public void setsueldo(int sueldo)
        {
            this.sueldo = 500;
        }
    }

}
