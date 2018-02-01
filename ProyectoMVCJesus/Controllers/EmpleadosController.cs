using ProyectoMVCJesus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVCJesus.Controllers
{
    public class EmpleadosController : Controller
    {
        ModeloHospital modelo;

        public EmpleadosController()
        {
            this.modelo = new ModeloHospital();
        }

        // GET: Empleados
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TodosEmpleados(String orden,String direccion,String campo)
        {
            List<EMP> lista = modelo.GetEmpleados();
            ViewBag.direccion = "ASC";
            if (orden != null )
            {
                if (campo == "apellido")
                {
                    if (direccion == "ASC")
                    {
                        lista = lista.OrderBy(z => z.APELLIDO).ToList();
                        ViewBag.direccion = "DESC";
                    }
                    else
                    {
                        lista = lista.OrderByDescending(z => z.APELLIDO).ToList();
                    }
                }

                if (campo == "oficio")
                {
                    if (direccion == "ASC")
                    {
                        lista = lista.OrderBy(z => z.OFICIO).ToList();
                        ViewBag.direccion = "DESC";
                    }
                    else
                    {
                        lista = lista.OrderByDescending(z => z.OFICIO).ToList();
                    }
                }

                if (campo == "salario")
                {
                    if (direccion == "ASC")
                    {
                        lista = lista.OrderBy(z => z.SALARIO).ToList();
                        ViewBag.direccion = "DESC";
                    }
                    else
                    {
                        lista = lista.OrderByDescending(z => z.SALARIO).ToList();
                    }
                }

            }
            return View(lista);
        }
    }
}








//MIO
//    lista = lista.OrderBy(z => z.APELLIDO).ToList();
//    ViewBag.direccion = "DESC";

//}
//else
//{
//    lista = lista.OrderByDescending(z => z.APELLIDO).ToList();
//}