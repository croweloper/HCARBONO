using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Net.Http;
using Newtonsoft.Json;
using HuellaCarbono.BE;
using System.Text;
using HuellaCarbono.BE.Result;

namespace HuellaCarbonoWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            ViewBag.App = ConfigurationManager.AppSettings.Get("UrlAPP").ToString();
            return View();
        }

        public ActionResult autenticacion(UsuarioBE oBE) {
            string UrlWebApiHuellaCarbono = ConfigurationManager.AppSettings["UrlWebApiHuellaCarbono"];

            string apiUrl = UrlWebApiHuellaCarbono + "api/HuellaCarbono/UsuarioLogin";
            var result = new HttpResponseMessage();

            using (var client = new HttpClient())
            {
                var jsonObject = JsonConvert.SerializeObject(oBE);
                var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                result = client.PostAsync(apiUrl, content).Result;

                var dataObjects = "";

                dataObjects = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<UsuarioResult>(dataObjects);

                if (response.result == true) {
                    Session[response.data.dni] = response.data.id;
                }
                
                return Json(response);
            }
            //UrlWebApiHuellaCarbono
        }
    }
}