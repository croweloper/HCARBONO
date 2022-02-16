using HuellaCarbono.BE;
using HuellaCarbono.BL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace HuellaCarbonoWeb.Controllers
{
    public class HCarbonoController : Controller
    {
        // GET: HCarbono
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Tramos() {
            return PartialView("~/Views/Home/_Tramos.cshtml");
        }

        [HttpPost]
        public ActionResult ListarTipoTransporte() {
            var huellaTransBL = new HuellaCall();

            var listado_tipo_transporte = huellaTransBL.ListarTipoTransporte();
            var listado_metropolitano = huellaTransBL.ListarMetropolitano();
            var listado_tren = huellaTransBL.ListarTren();

            return Json(
                new
                {
                    listado_tipo_transporte,
                    listado_metropolitano,
                    listado_tren
                }
           );

            
        }

        [HttpPost]
        public ActionResult ListadoTipoVehiculo(TipoVehiculoBE oTipoVehiculoBE) {
            var huellaTransBL = new HuellaCall();

            var listado_tipovehiculo = huellaTransBL.ListarTipoVehiculo(oTipoVehiculoBE);
            return  Json(listado_tipovehiculo);
        }

        [HttpPost]
        public ActionResult RegistrarHuella(HuellaGeneralBE oBE) {
            var huellaTransBL = new HuellaCall();
            return Json(huellaTransBL.RegistrarHuellaGeneral(oBE));
        }

        [HttpPost]
        public ActionResult ListarTipoCombustible() {
            var huellaTransBL = new HuellaCall();
            return Json(huellaTransBL.ListarTipoCombustible());
        }

        public PartialViewResult VFinal()
        {
            return PartialView("~/Views/HCarbono/VFinal.cshtml");
        }

        //public ActionResult getDatosGoogle(string tipo, string consulta)
        //{

        //    var url = 'http://maps.google.com/maps/api/geocode/json?address='+ urlencode($dir).'&sensor=false&language=es';
        ////set the url, number of POST vars, POST data
        //$defaults = array(
        //            CURLOPT_POST => 1,
        //            CURLOPT_HEADER => 0,
        //            CURLOPT_URL => $url,
        //            CURLOPT_FRESH_CONNECT => 1,
        //            CURLOPT_RETURNTRANSFER => 1,
        //            CURLOPT_FORBID_REUSE => 1,
        //            CURLOPT_TIMEOUT => 4
        //    ); //execute post
        //$ch = curl_init();
        //    curl_setopt_array($ch,$defaults);
        //$result = json_decode(curl_exec($ch), true);
        //    curl_close($ch); //close connection
        //    return $result;

        //}

        public ActionResult getDatosGoogle(string direccion)
        {
            var dataObjects = "";
            try
            {
                var url = "http://maps.google.com/maps/api/geocode/json?address=" + HttpUtility.UrlEncode(direccion) + "&sensor=false&language=es";

                Default oDefault = new Default();

                oDefault.CURLOPT_POST = 1;
                oDefault.CURLOPT_HEADER = 0;
                oDefault.CURLOPT_URL = url;

                oDefault.CURLOPT_FRESH_CONNECT = 1;
                oDefault.CURLOPT_RETURNTRANSFER = 1;
                oDefault.CURLOPT_FORBID_REUSE = 1;
                oDefault.CURLOPT_TIMEOUT = 4;

                string apiUrl = url;
                var result = new HttpResponseMessage();

               
                using (var client = new HttpClient())
                {
                    var jsonObject = JsonConvert.SerializeObject(oDefault);
                    var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                    result = client.PostAsync(apiUrl, content).Result;



                    dataObjects = result.Content.ReadAsStringAsync().Result;
                    //var response = JsonConvert.DeserializeObject<Huella_ListaResult>(dataObjects);
                    //return response.data;
                }

            }
            catch (Exception)
            {

                throw;
            }
          
            return Json(dataObjects);
            //$ch = curl_init();
            //    curl_setopt_array($ch,$defaults);
            //$result = json_decode(curl_exec($ch), true);
            //    curl_close($ch); //close connection
            //    return $result;

        }

        
    }

    public class Default {
       public int CURLOPT_POST { get; set; }
       public int CURLOPT_HEADER { get; set; }
       public string  CURLOPT_URL { get; set; }

       public int CURLOPT_FRESH_CONNECT { get; set; }
       public int CURLOPT_RETURNTRANSFER { get; set; }
       public int CURLOPT_FORBID_REUSE  { get; set; }
       public int CURLOPT_TIMEOUT { get; set; }
    }

}