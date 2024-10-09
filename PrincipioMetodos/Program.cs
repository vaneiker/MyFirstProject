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

            var listado= CrudPlan.ListaPlanes();

            foreach(var plan in listado)
            {



                CrudPlan.Create(new Planes()
                {
                    PlanID = plan.PlanID,
                    NombrePlan=plan.NombrePlan+" Plus",
                    VelocidadMbps=plan.VelocidadMbps,
                    PrecioMensual=plan.PrecioMensual,

                });


                //Console.WriteLine($"{plan.PlanID}***{plan.NombrePlan}***{plan.VelocidadMbps}***{plan.PrecioMensual} ");   

            }
            CrudPlan.Create(new Planes()
            {
                PlanID = 0,
                NombrePlan = "Aprendiendo algo nuevo" + " Plus",
                VelocidadMbps = "123",
                PrecioMensual = 10m,

            });

            Console.ReadKey();

        }
    }
}