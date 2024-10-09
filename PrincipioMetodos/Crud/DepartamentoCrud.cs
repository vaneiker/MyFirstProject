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
    public class DepartamentoCrud
    {
        public static List<Departamento> ListaDepartamento()
        {
            using (var dbo = new POS_SITEEntities())
            {
                IEnumerable<Departamento> RetornarValue = dbo.Database.SqlQuery<Departamento>("EXEC [Departamento].[SP_GET_LIST_DEPARTAMENTO]"
                    ).ToList();
                return RetornarValue.ToList();
            }
        }

        public static void Create(Departamento dep)
        {
            using (var dbo = new POS_SITEEntities())
            {
                IEnumerable<Empleado> RetornarValue = dbo.Database.SqlQuery<Empleado>("EXEC [Departamento].[SP_SET_ADD_UPADATE_Departamento] @IdDepartamento,@NombreDepartamento,@Extencion,@Responsable,@Objetivo,@NumeroEmpleados,@Presupuesto,@Usuario",
                     new SqlParameter("@IdDepartamento", dep.IdDepartamento),
                     new SqlParameter("@NombreDepartamento", dep.NombreDepartamento),
                     new SqlParameter("@Extencion", dep.Extencion),
                     new SqlParameter("@Responsable", dep.Responsable),
                     new SqlParameter("@Objetivo", dep.Objetivo),
                     new SqlParameter("@NumeroEmpleados", dep.NumeroEmpleados),
                     new SqlParameter("@Presupuesto", dep.Presupuesto),
                     new SqlParameter("@Usuario", dep.UsuarioCrea)
                    ).ToList();
            }
            //Implementar logica para crear empleado
        }

        public static void InactivarDepartamento(Departamento dep)
        {
            using (var dbo = new POS_SITEEntities())
            {
                IEnumerable<Empleado> RetornarValue = dbo.Database.SqlQuery<Empleado>("EXEC [Departamento].[SP_SET_INACTIVAR_DEPARTAMENTO] @IdDepartamento,@Usuario",
                     new SqlParameter("@IdDepartamento", dep.IdDepartamento), 
                     new SqlParameter("@Usuario", dep.UsuarioCrea)
                    ).ToList();
            }
            //Implementar logica para crear empleado
        }
    }
}
