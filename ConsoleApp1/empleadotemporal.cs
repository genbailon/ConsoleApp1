using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoEmpleados
{
    class empleadotemporal : empleado
    {

        public int añodeentrada { get; set; }
        public int añodesalida { get; set; }


        public empleadotemporal(string nombre, string apellido, int edad, string departamento, int sueldo) : base(nombre, apellido, edad, departamento, sueldo)
        {
            this.añodesalida = añodesalida;
            this.añodeentrada = añodeentrada;
            this.sueldo = sueldo;

        }

        public int getañodeentrada()
        {
            return añodeentrada;
        }
        public void setañodeentrada(int añodeentrada)
        {
            this.añodeentrada = añodeentrada;
        }

        public int getañodesalida()
        {
            return añodesalida;
        }
        public void setañodesalida(int añodesalida)
        {
            this.añodesalida = añodesalida;
        }

        public void datosdeltemporal() 
        {

        }
    }
}
