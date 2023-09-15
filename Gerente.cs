using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class Gerente : IEmpleado, IAuditable
    {
        string nombre = "";
        float salario = 0;

        public string Nombre { get => nombre; set => nombre = value; }
        public float Salario { get => salario; set => salario = value; }


        public Gerente(string nombre, float salario)
        {
            Nombre = nombre;
            Salario = salario;
        }

        public string NombreEmpleado()
        {
            //Console.WriteLine("Ingrese el nombre del gerente");
            //Nombre = Console.ReadLine();

            return ( "El nombre del Gerente es: " + Nombre);
        }

        public float CalcularSalario()
        {
            //int ingreso = 0;
            //int egreso = 0;
            //Console.WriteLine("Ingrese el valor de los ingresos del gerente");
            //ingreso = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ingrese el valor de los egresos del gerente");
            //egreso = Convert.ToInt32(Console.ReadLine());

            //Salario = ingreso - egreso;
            Console.WriteLine("Los ingresos del gerente son de : $");
            return (Salario);
        }

        public string RegistrarAuditoria()
        {
            return ("Acción del gerente auditada");
        }
    }
}
