using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoEmpleados
{
    class empleadoporhoras : empleado  //herencia
    {

        private int horastrabajadas { get; set; }
        public int horasquetrabajo { get; set; }
        private int valorapagar { get; set; }

        public empleadoporhoras(string nombre, string apellido, int edad, string departamento, int sueldo ) : base(nombre, apellido, edad, departamento, sueldo)
        {

            this.horastrabajadas = 30;
            this.horasquetrabajo = horasquetrabajo;

        }


         private int gethorastrabajadas() 
         {
            return horastrabajadas;
         }
        public void sethorastrabajadas( int horastrabajadas) 
        {
            this.horastrabajadas = horastrabajadas;
        }

        public  int gethorasquetrabajo()
        {
            return horasquetrabajo;
        }
        public void sethorasquetrabajo(int horasquetrabajo)
        {
            this.horasquetrabajo = horasquetrabajo;
        }



        public void valor() 
        {

            valorapagar = horastrabajadas * horasquetrabajo;
    
        }

        public void imprimirempleadoporhoras() 
        {
            Console.WriteLine("sueldo es de:" + this.valorapagar);

        }



    }


}

