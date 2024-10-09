using PrincipioMetodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using PrincipioMetodos.EF_MODEL;
using System.Data.SqlClient;
using PrincipioMetodos.Common;


namespace PrincipioMetodos.Crud
{
    public class CrudEmpleado
    {

        public static Empleado OptenerUnEmpleadoPorSuNombre(string name = "freddy")
        {

            return Read().Where(x => x.Nombre.ToLower() == name.ToLower()).FirstOrDefault();
        }
        public static List<Empleado> GetEmpleados()
        {
            return Read().ToList();

        } 
        public static void Create(Empleado empleado)
        {
            decimal _ars = 0.00m;
            decimal _afp = 0.00m;
            decimal _isr = 0.00m;
            decimal _deduciones = 0.00m;

            _ars = Utility.ARS(empleado.SueldoBruto);
            _afp = Utility.AFP(empleado.SueldoBruto);
            _isr = Utility.IRS(empleado.SueldoBruto);
            _deduciones = _ars + _afp + _isr;

            using (var dbo = new POS_SITEEntities())
            {
                IEnumerable<Empleado> RetornarValue = dbo.Database.SqlQuery<Empleado>("EXEC [dbo].[SP_SET_EMPLEADO]@Nombre,@SueldoBruto,@Deduciones,@SueldoNeto,@Ars,@Afp,@Isr",
                     new SqlParameter("@Nombre", empleado.Nombre),
                     new SqlParameter("@SueldoBruto", empleado.SueldoBruto),
                     new SqlParameter("@Deduciones", _deduciones),
                     new SqlParameter("@SueldoNeto", (empleado.SueldoBruto - _deduciones)),
                     new SqlParameter("@Ars", _ars),
                     new SqlParameter("@Afp", _afp),
                     new SqlParameter("@Isr", _isr)
                    ).ToList();
            }
            //Implementar logica para crear empleado
        }
        public static void Update(Empleado empleado)
        {
            decimal _ars = 0.00m;
            decimal _afp = 0.00m;
            decimal _isr = 0.00m;
            decimal _deduciones = 0.00m;

            _ars = Utility.ARS(empleado.SueldoBruto);
            _afp = Utility.AFP(empleado.SueldoBruto);
            _isr = Utility.IRS(empleado.SueldoBruto);
            _deduciones = _ars + _afp + _isr;

            using (var dbo = new POS_SITEEntities())
            {
                IEnumerable<Empleado> RetornarValue = dbo.Database.SqlQuery<Empleado>("EXEC [dbo].[SP_SET_UPDATE_EMPLEADO]@IdEmpleado,@Nombre,@SueldoBruto,@Deduciones,@SueldoNeto,@Ars,@Afp,@Isr",
                     new SqlParameter("@IdEmpleado", empleado.IdEmpleado),
                     new SqlParameter("@Nombre", empleado.Nombre),
                     new SqlParameter("@SueldoBruto", empleado.SueldoBruto),
                     new SqlParameter("@Deduciones", _deduciones),
                     new SqlParameter("@SueldoNeto", (empleado.SueldoBruto - _deduciones)),
                     new SqlParameter("@Ars", _ars),
                     new SqlParameter("@Afp", _afp),
                     new SqlParameter("@Isr", _isr)
                    ).ToList();
            }
        }
        public static void Delete(int? IdEmpleado)
        {
            using (var dbo = new POS_SITEEntities())
            {
                IEnumerable<Empleado> RetornarValue = dbo.Database.SqlQuery<Empleado>("EXEC [dbo].[SP_SET_DESACTIVAR_EMPLEADO]@IdEmpleado",
                     new SqlParameter("@IdEmpleado", IdEmpleado)
                    ).ToList();
            }
        }
        public static List<Empleado> Read()
        {
            using (var dbo = new POS_SITEEntities())
            {
                IEnumerable<Empleado> RetornarValue = dbo.Database.SqlQuery<Empleado>("EXEC [dbo].[SP_GET_LIST_EMPLEADO]"
                    ).ToList();
                return RetornarValue.ToList();
            }
        }

    }
}
