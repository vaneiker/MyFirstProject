using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrincipioMetodos.Common;
using PrincipioMetodos.EF_MODEL;
using PrincipioMetodos.Models;


namespace PrincipioMetodos.Crud
{
    public class CrudPlan
    { 
        public static List<Planes> ListaPlanes()
        {
            using (var dbo = new POS_SITEEntities())
            {
                IEnumerable<Planes> RetornarValue = dbo.Database.SqlQuery<Planes>("EXEC [dbo].[SP_GET_PLAN_DETALLE]"
                    ).ToList();
                return RetornarValue.ToList();
            }
        }

        public static void Create(Planes pl)
        {
            using (var dbo = new POS_SITEEntities())
            {
                IEnumerable<Planes> RetornarValue = dbo.Database.SqlQuery<Planes>("EXEC [dbo].[SP_SET_ADD_UPADATE_Plan] @PlanID,@NombrePlan,@VelocidaMbps,@PrecioMensual",                   
                     new SqlParameter("@PlanID", pl.PlanID),
                     new SqlParameter("@NombrePlan", pl.NombrePlan),
                     new SqlParameter("@VelocidaMbps", pl.VelocidadMbps),
                     new SqlParameter("@PrecioMensual", pl.PrecioMensual)
                    ).ToList();
            } 
        }
    }
}
