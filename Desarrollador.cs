using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class Desarrollador : IEmpleado, IAuditable
    {
        string nombre = "";
        float salario = 0;

        public string Nombre { get => nombre; set => nombre = value; }
        public float Salario { get => salario; set => salario = value; }


        public Desarrollador(string nombre, int salario)
        {
            Nombre = nombre;
            Salario = salario;
        }
        public float CalcularSalario()
        {
            //int ingreso = 0;
            //int egreso = 0;
            //Console.WriteLine("Ingrese el valor de los ingresos del desarrollador");
            //ingreso = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ingrese el valor de los egresos del desarrollador");
            //egreso = Convert.ToInt32(Console.ReadLine());

            //Salario = ingreso - egreso;
            Console.WriteLine("Los ingresos del desarrollador son de : $");
            return (Salario);
        }

        public string NombreEmpleado()
        {
            //Console.WriteLine("Ingrese el nombre del desarrollador");
            //Nombre = Console.ReadLine();

            return ("El nombre del desarrollador es: " + Nombre);
        }

        public string RegistrarAuditoria()
        {
            return ("Acción del desarrollador auditada");
        }
    }
}
