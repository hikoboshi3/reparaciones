using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using static Modelos.Entidades;

namespace BLL
{

    public class ApiCaller
    {
        #region Vehiculo
            public long IngresarAutomovil(Modelos.Entidades.Automovil auto)
            {
                RestClient client = new RestClient("http://localhost:5275/");
                RestRequest request = new RestRequest("IngresarAutomovil", Method.Post);
                request.AddBody(auto);
                RestResponse response = client.Execute(request);
                return Convert.ToInt64(@response.Content);
            }

            public long IngresarMoto(Modelos.Entidades.Moto moto)
            {
                RestClient client = new RestClient("http://localhost:5275/");
                RestRequest request = new RestRequest("IngresarMoto", Method.Post);
                request.AddBody(moto);
                RestResponse response = client.Execute(request);
                return Convert.ToInt64(@response.Content);
            }
        #endregion

        public string GetRepuestos()
        {
            RestClient client = new RestClient("http://localhost:5275/");
            RestRequest request = new RestRequest("GetRepuestos", Method.Post);
            RestResponse response = client.Execute(request);
            return @response.Content;
        }

        #region Acciones
            public long IngresarPresupuesto(Presupuesto _presupuesto)
            {
                RestClient client = new RestClient("http://localhost:5275/");
                RestRequest request = new RestRequest("IngresarPresupuesto", Method.Post);
                request.AddBody(_presupuesto);
                RestResponse response = client.Execute(request);
                return Convert.ToInt64(@response.Content);
            }

            public long IngresarDesperfecto(Desperfecto _desperfecto)
            {
                RestClient client = new RestClient("http://localhost:5275/");
                RestRequest request = new RestRequest("IngresarDesperfecto", Method.Post);
                request.AddBody(_desperfecto);
                RestResponse response = client.Execute(request);
                return Convert.ToInt64(@response.Content);
            }

            public void DesperfectoRepuesto(DesperfectoRepuesto _desRep)
            {
                RestClient client = new RestClient("http://localhost:5275/");
                RestRequest request = new RestRequest("DesperfectoRepuesto", Method.Post);
                request.AddBody(_desRep);
                client.Execute(request);
            }

            public void ActualizarPresupuesto(Presupuesto _presupuesto)
            {
                RestClient client = new RestClient("http://localhost:5275/");
                RestRequest request = new RestRequest("ActualizarPresupuesto", Method.Post);
                request.AddBody(_presupuesto);
                client.Execute(request);
            }
        #endregion
    }
}
