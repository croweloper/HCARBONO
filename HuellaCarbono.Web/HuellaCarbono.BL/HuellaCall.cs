using HuellaCarbono.BE;
using HuellaCarbono.BE.Result;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Configuration;

namespace HuellaCarbono.BL
{
    public class HuellaCall
    {
        public List<TipoTransporteBE> ListarTipoTransporte()
        {
            string apiUrl = ConfigurationManager.AppSettings["UrlWebApiHuellaCarbono"] + "api/HuellaCarbono/ListarTipoTransporte";
            var result = new HttpResponseMessage();

            using (var client = new HttpClient())
            {
                var jsonObject = JsonConvert.SerializeObject("");
                var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                result = client.PostAsync(apiUrl, content).Result;

                var dataObjects = "";

                dataObjects = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<TipoTransporteResult>(dataObjects);
                return response.data;
            }
         }

        public List<TipoCombustibleBE> ListarTipoCombustible()
        {
            string apiUrl = ConfigurationManager.AppSettings["UrlWebApiHuellaCarbono"] + "api/HuellaCarbono/ListarTipoCombustible";
            var result = new HttpResponseMessage();

            using (var client = new HttpClient())
            {
                var jsonObject = JsonConvert.SerializeObject("");
                var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                result = client.PostAsync(apiUrl, content).Result;

                var dataObjects = "";

                dataObjects = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<TipoCombustibleResult>(dataObjects);
                return response.data;
            }
        }

        public List<TipoVehiculoBE> ListarTipoVehiculo(TipoVehiculoBE oTipoVehiculoBE)
        {
            string apiUrl =  ConfigurationManager.AppSettings["UrlWebApiHuellaCarbono"] + "api/HuellaCarbono/ListarTipoVehiculo";
            var result = new HttpResponseMessage();

            using (var client = new HttpClient())
            {
                var jsonObject = JsonConvert.SerializeObject(oTipoVehiculoBE);
                var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                result = client.PostAsync(apiUrl, content).Result;

                var dataObjects = "";

                dataObjects = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<TipoVehiculoResult>(dataObjects);
                return response.data;
            }
        }
        public HuellaDetalleResult RegistrarHuellaGeneral(HuellaGeneralBE oBE)
        {
            string apiUrl = ConfigurationManager.AppSettings["UrlWebApiHuellaCarbono"] + "api/HuellaCarbono/RegistrarHuella";
            var result = new HttpResponseMessage();

            using (var client = new HttpClient())
            {
                var jsonObject = JsonConvert.SerializeObject(oBE);
                var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                result = client.PostAsync(apiUrl, content).Result;

                var dataObjects = "";

                dataObjects = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<HuellaDetalleResult>(dataObjects);
                return response;
            }
        }

        public List<Huella_ListaBE> ListarMetropolitano()
        {
            string apiUrl = ConfigurationManager.AppSettings["UrlWebApiHuellaCarbono"] + "api/HuellaCarbono/ListarTrenMetro";
            var result = new HttpResponseMessage();

            Huella_ListaBE oHUELLA_TIPO_DESCRIPCIONBE = new Huella_ListaBE();
            oHUELLA_TIPO_DESCRIPCIONBE.ID_TIPO_DESCRIP = 2;

            using (var client = new HttpClient())
            {
                var jsonObject = JsonConvert.SerializeObject(oHUELLA_TIPO_DESCRIPCIONBE);
                var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                result = client.PostAsync(apiUrl, content).Result;

                var dataObjects = "";

                dataObjects = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<Huella_ListaResult>(dataObjects);
                return response.data;
            }
        }
        public List<Huella_ListaBE> ListarTren()
        {
            string apiUrl = ConfigurationManager.AppSettings["UrlWebApiHuellaCarbono"] + "api/HuellaCarbono/ListarTrenMetro";
            var result = new HttpResponseMessage();

            Huella_ListaBE oHUELLA_TIPO_DESCRIPCIONBE = new Huella_ListaBE();
            oHUELLA_TIPO_DESCRIPCIONBE.ID_TIPO_DESCRIP = 3;
            using (var client = new HttpClient())
            {
                var jsonObject = JsonConvert.SerializeObject(oHUELLA_TIPO_DESCRIPCIONBE);
                var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                result = client.PostAsync(apiUrl, content).Result;

                var dataObjects = "";

                dataObjects = result.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<Huella_ListaResult>(dataObjects);
                return response.data;
            }
        }
    }
}
