using System;
using System.Collections.Generic;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAuditable> auditables = new List<IAuditable>();

            auditables.Add(new Contador("Camilo", 8000));
            auditables.Add(new Desarrollador("Marisol", 10000));
            auditables.Add(new Gerente("Daniel", 15000));


            foreach (var item in auditables)
            {
                if (item is Contador) {

                    Contador c = (Contador) item;
                    Console.WriteLine(c.NombreEmpleado());
                    Console.WriteLine(c.CalcularSalario());
                    Console.WriteLine(c.RegistrarAuditoria());
                }
                else if(item is Desarrollador)
                {
                    Desarrollador d = ( Desarrollador)item;
                    Console.WriteLine(d.NombreEmpleado());
                    Console.WriteLine(d.CalcularSalario());
                    Console.WriteLine(d.RegistrarAuditoria());
                }
                else
                {
                    Gerente g = ( Gerente )item;
                    Console.WriteLine(g.NombreEmpleado());
                    Console.WriteLine(g.CalcularSalario());
                    Console.WriteLine(g.RegistrarAuditoria());
                }

                
            }
        }
    }
}
