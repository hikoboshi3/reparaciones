using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace reparaciones_UI
{


    public class ApiCaller
    {
        //Esto se hizo a modo de referencia, para invocar una api de terceros.
        public string touchDown()
        {
            string X = "";

            try
            {
                //declare api client 
                HttpClient client = new HttpClient();
                //Initialize api client
                if (client.BaseAddress == null)
                    client.BaseAddress = new Uri("http://localhost:5275/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Add headers
  
                HttpResponseMessage resp = client.GetAsync("/weatherforecast1").Result;
                if (resp.IsSuccessStatusCode)
                {
                    var resultado = resp.Content.ReadAsStringAsync();
                    string result = resultado.Result;
                    return resultado.Result;

                }
                else
                {
                    return "";
                    //var resultado = resp.Content.ReadAsStringAsync().Result;
                    //var result = JsonConvert.DeserializeObject<ResultServer>(resultado);
                    //throw new Exception(string.Format("Message:{0}, ExceptionMessage: {1}", result.Message, result.ExceptionMessage));
                }
            }
            catch (Exception ex)
            {
                    throw new Exception(string.Format("AddVehicle - Error: {0}", ex.Message));
            }


        }



    }
}
