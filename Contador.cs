using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class Contador: IEmpleado, IAuditable
    {
        string nombre = "";
        float salario = 0;

        public string Nombre { get => nombre; set => nombre = value; }
        public float Salario { get => salario; set => salario = value; }


        public Contador(string nombre, float salario)
        {
            Nombre = nombre;
            Salario = salario;
        }



        public string RegistrarAuditoria()
        {
            return ("Acción del Contador auditada");
        }

        public string NombreEmpleado()
        {
            //Console.WriteLine("Ingrese el nombre del Contador");
            //Nombre = Console.ReadLine();


            return ("El nombre del Contador es: " + Nombre);
        }

        public float CalcularSalario()
        {
            //int ingreso = 0;
            //int egreso = 0;
            //Console.WriteLine("Ingrese el valor de los ingresos del contador");
            //ingreso = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ingrese el valor de los egresos del contador");
            //egreso = Convert.ToInt32(Console.ReadLine());

            //Salario = ingreso - egreso;
            Console.WriteLine("Los ingresos del contador son de : $");
            return (Salario);
        }
    }
}
