using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Claims;
using PrincipioMetodos.Common;
using PrincipioMetodos.Crud;
using PrincipioMetodos.Models;

namespace PrincipioMetodos
{
    class Program
    {

        static void Main(string[] args)
        {

            Empleado Empledo = new Empleado();
            List<Empleado> empleados = new List<Empleado>();
            
            string nombre = "";
            decimal sueldobruto = 0.00m;


            Console.WriteLine("Digite su Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite su sueldo: ");
            sueldobruto =decimal.Parse(Console.ReadLine());


            Empledo.Nombre= nombre;
            Empledo.SueldoBruto= sueldobruto;


            CrudEmpleado.Create(Empledo);





            foreach (var i in CrudEmpleado.GetEmpleados())
            {

               
                string name = i.Nombre;
                decimal SueldoBruto = i.SueldoBruto;

                decimal _ars = 0.00m;
                decimal _afp = 0.00m;
                decimal _isr = 0.00m;
                decimal _deduciones = 0.00m;

                _ars = Utility.ARS(SueldoBruto);
                _afp = Utility.AFP(SueldoBruto);
                _isr = Utility.IRS(SueldoBruto);
                _deduciones = _ars + _afp + _isr;

                empleados.Add(new Empleado()
                {
                    Nombre = name,
                    SueldoBruto = SueldoBruto,
                    ars = _ars,
                    afp = _afp,
                    isr = _isr,
                    Deduciones = _deduciones,
                    SueldoNeto = SueldoBruto - _deduciones
                }); 
            }
            foreach (var emp in empleados)
            {

                Console.Write("*************\n");
                Console.WriteLine(
                     $"Nombre:{Utility.CapitalizarPrimeraLetra(emp.Nombre)} \n" +
                     $"SueldoBruto:{emp.SueldoBruto} \n" +
                     $"SueldoNeto:{emp.SueldoNeto} \n" +
                     $"afp:{emp.afp} \n" +
                     $"ars:{emp.ars} \n" +
                     $"irs:{emp.isr}\n" +
                     $"Total de Deduciones:{emp.Deduciones}\n"
                    );
            }


            Console.ReadKey();

        }
    }
}