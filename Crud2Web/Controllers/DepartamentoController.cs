using Crud2Web.Models.Departamento;
using PrincipioMetodos.Crud;
using PrincipioMetodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace Crud2Web.Controllers
{
    public class DepartamentoController : Controller
    {
        // GET: Departamento
        public ActionResult ListadoDepartamento()
        {
            var resultado = DepartamentoCrud.ListaDepartamento().Select(departamento => new DepartamentoViewModel()
            {
                id = departamento.IdDepartamento,
                Departamento = departamento.NombreDepartamento.ToUpper(),
                Representante = departamento.Responsable,
                Objetivo = departamento.Objetivo
            }).ToList();

            return View(resultado);
        }
        public ActionResult VerDepartamento(int IdDepartamento = 1)
        {
            var result = new DepartamentoViewModel();

            var resultado = DepartamentoCrud.ListaDepartamento();

            var response = resultado.Where(x => x.IdDepartamento == IdDepartamento).Select(x => new DepartamentoViewModel()
            {
                id = x.IdDepartamento,
                Departamento = x.NombreDepartamento,
                Representante = x.Responsable,
                Objetivo = x.Objetivo,
                Presupuesto = x.Presupuesto,
            }).FirstOrDefault();

            if (response == null)
            {
                result.id = 0;
                result.Departamento = "Registro no encontrado";
                result.Representante = "Registro no encontrado";
                result.Objetivo = "Registro no encontrado";
                result.Presupuesto = 0;
            }
            else
            {
                result = response;
            }

            return View(result);
        }
        public ActionResult DepartamentoMantenimiento(int IdDepartamento = 1)
        {
            string mensajeBoton = "";

            var result = new DepartamentoViewModel();

            var resultado = DepartamentoCrud.ListaDepartamento();

            var response = resultado.Where(x => x.IdDepartamento == IdDepartamento).Select(x => new DepartamentoViewModel()
            {

                id = x.IdDepartamento,
                Departamento = x.NombreDepartamento,
                Ext = x.Extencion,
                Representante = x.Responsable,
                Objetivo = x.Objetivo,
                NumeroEmpleados = x.NumeroEmpleados,
                Presupuesto = x.Presupuesto,
            }).FirstOrDefault();

            if (response == null)
            {
                result.id = 0;
                result.Departamento = string.Empty;
                result.Ext = string.Empty;
                result.Representante = string.Empty;
                result.Objetivo = string.Empty;
                result.NumeroEmpleados = 0;
                result.Presupuesto = 0;
                mensajeBoton = "Guardar";
            }
            else
            {
                result = response;
                mensajeBoton = "Actualizar";
            }

            ViewBag.mensajeBoton = mensajeBoton;

            return View(result);
        }

        [HttpPost]
        public RedirectResult GuardarDepartamento(DepartamentoViewModel model)
        {
            var contenedor = new Departamento();
            
            contenedor.NombreDepartamento = model.Departamento;
            contenedor.Extencion = model.Ext;
            contenedor.Responsable = model.Representante;
            contenedor.Objetivo = model.Objetivo;
            contenedor.NumeroEmpleados = model.NumeroEmpleados;
            contenedor.Presupuesto = model.Presupuesto;
            contenedor.UsuarioCrea = "ADMIN";
            contenedor.IdDepartamento = model.id;
            DepartamentoCrud.Create(contenedor);

            return Redirect("ListadoDepartamento");
        }
        public ActionResult BorrarDepartamento(int IdDepartamento = 1)
        { 
            var result = new DepartamentoViewModel();

            var resultado = DepartamentoCrud.ListaDepartamento();

            var response = resultado.Where(x => x.IdDepartamento == IdDepartamento).Select(x => new DepartamentoViewModel()
            {

                id = x.IdDepartamento,
                Departamento = x.NombreDepartamento,
                Ext = x.Extencion,
                Representante = x.Responsable,
                Objetivo = x.Objetivo,
                NumeroEmpleados = x.NumeroEmpleados,
                Presupuesto = x.Presupuesto,
            }).FirstOrDefault();

            if (response == null)
            {
                result.id = 0;
                result.Departamento = string.Empty;
                result.Ext = string.Empty;
                result.Representante = string.Empty;
                result.Objetivo = string.Empty;
                result.NumeroEmpleados = 0;
                result.Presupuesto = 0;
               
            }
            else
            {
                result = response;
                 
            } 

            return View(result);
        }


        [HttpPost]
        public RedirectResult Borrar(DepartamentoViewModel model)
        {
            var contenedor = new Departamento(); 
            contenedor.UsuarioCrea = "ADMIN";
            contenedor.IdDepartamento = model.id;
            DepartamentoCrud.InactivarDepartamento(contenedor); 
            return Redirect("ListadoDepartamento");
        }
    }
}