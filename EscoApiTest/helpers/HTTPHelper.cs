using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EscoApiTest.models.response;
using Newtonsoft.Json;

namespace EscoApiTest.helpers {
    static class HTTPHelper {

        /// <summary>
        /// Consume la api recibiendo el tipo de objeto de consulta a enviar, y el tipo de objetos a recibir.
        /// Este metodo se usa cuando se recibe una lista de objetos de respuesta, ej: Ordenes, Solicitudes FCI, Boletos, etc
        /// </summary>
        /// <typeparam name="T">Tipo de dato de response</typeparam>
        /// <param name="Payload">objeto request con la consulta a realizar</param>
        /// <param name="endPoint">Metodo al que se llama de EscoApi</param>
        /// <param name="url">Url Base de EscoApi</param>
        /// <param name="version">Version de EscoApi a utilizar</param>
        /// <param name="token">Token de autenticacion</param>
        /// <param name="errorHandler">Funcion generica que se invoca si se produce un error</param>
        /// <returns></returns>
        public static async Task<List<T>> ConsumirMetodoPostGenerico<T>(object Payload, string endPoint, string url, string version, string token, Func<string, int> errorHandler) {

            //se prepara el objeto de request a enviar
            string stringPayload = await Task.Run(() => JsonConvert.SerializeObject(Payload));
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");

            //se crea la conexion con EscoApi y se usa para procesar la respuesta
            using (var httpClient = new HttpClient()) {

                //se definen los encabezados del request
                httpClient.BaseAddress = CrearURL(url,version);
                httpClient.DefaultRequestHeaders.Add("api-version", version);
                httpClient.DefaultRequestHeaders.Add("Authorization", "bearer " + token);

                //se hace la llamada a EscoApi
                var httpResponse = await httpClient.PostAsync(endPoint, httpContent);

                //proceso el estado de la respuesta de EscoApiTest de acuerdo a su codigo
                switch (httpResponse.StatusCode) {

                    //no estoy autorizado a usar EscoApi (sebo autenticarme y usar un token valido)
                    case HttpStatusCode.Unauthorized:
                        errorHandler("NO AUTORIZADO");
                        throw new Exception("NO AUTORIZADO");

                    //el response el valido, se convierte la respuesta al tipo de objetos solicitado
                    case HttpStatusCode.OK:
                        string resultado = await httpResponse.Content.ReadAsStringAsync();
                        try {
                            return JsonConvert.DeserializeObject<List<T>>(resultado);
                        } catch (Exception ex) {
                            return null;
                        }

                    //si se genero un error se muestra el mensaje, llamando a una funcion generica de manejo de error que se pasa como parametro (errorHandler)
                    case HttpStatusCode.BadRequest:
                        string resultadoError = await httpResponse.Content.ReadAsStringAsync();
                        try {                            
                            ErrorResponse error = JsonConvert.DeserializeObject<ErrorResponse>(resultadoError);
                            errorHandler(error.error.Msj);
                            throw new Exception(error.error.Msj);
                        } catch (Exception ex) {
                            return null;
                        }

                    default:
                        return null;
                }
            }
        }


        /// <summary>
        /// Consume la api recibiendo el tipo de objeto de consulta a enviar, y el tipo de objetos a recibir.
        /// Este metodo se usa cuando se recibe un solo objeto de respuesta, ej: Login
        /// </summary>
        /// <typeparam name="T">Tipo de dato de response</typeparam>
        /// <param name="Payload">objeto request con la consulta a realizar</param>
        /// <param name="endPoint">Metodo al que se llama de EscoApi</param>
        /// <param name="url">Url Base de EscoApi</param>
        /// <param name="version">Version de EscoApi a utilizar</param>
        /// <param name="token">Token de autenticacion</param>
        /// <param name="errorHandler">Funcion generica que se invoca si se produce un error</param>
        /// <returns></returns>
        public static async Task<T> ConsumirMetodoPostGenericoItem<T>(object Payload, string endPoint, string url, string version, string token, Func<string, int> errorHandler) {

            //se prepara el objeto de request a enviar
            string stringPayload = await Task.Run(() => JsonConvert.SerializeObject(Payload));
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");

            //se crea la conexion con EscoApi y se usa para procesar la respuesta
            using (var httpClient = new HttpClient()) {

                //se definen los encabezados del request
                httpClient.BaseAddress = CrearURL(url, version);
                httpClient.DefaultRequestHeaders.Add("api-version", version);
                if (!endPoint.Equals("login"))
                    httpClient.DefaultRequestHeaders.Add("Authorization", "bearer " + token);

                //se hace la llamada a EscoApi
                var httpResponse = await httpClient.PostAsync(endPoint, httpContent);

                //proceso el estado de la respuesta de EscoApiTest de acuerdo a su codigo
                switch (httpResponse.StatusCode) {

                    //no estoy autorizado a usar EscoApi (sebo autenticarme y usar un token valido)
                    case HttpStatusCode.Unauthorized:
                        errorHandler("NO AUTORIZADO");
                        throw new Exception("NO AUTORIZADO");

                    //el response el valido, se convierte la respuesta al tipo de objetos solicitado
                    case HttpStatusCode.OK:
                        string resultado = await httpResponse.Content.ReadAsStringAsync();
                        try {
                            return JsonConvert.DeserializeObject<T>(resultado);
                        } catch (Exception ex) {
                            return default(T);
                        }

                    //si se genero un error se muestra el mensaje, llamando a una funcion generica de manejo de error que se pasa como parametro (errorHandler)
                    case HttpStatusCode.BadRequest:
                        string resultadoError = await httpResponse.Content.ReadAsStringAsync();
                        try {
                            ErrorResponse error = JsonConvert.DeserializeObject<ErrorResponse>(resultadoError);
                            errorHandler(error.error.Msj);
                            throw new Exception(error.error.Msj);
                        } catch (Exception ex) {
                            return default(T);
                        }

                    default:
                        return default(T);
                }
            }
        }

        public static async Task<string> ConsumirMetodoPost(object Payload, string endPoint, string url, string version, string token, Func<string, int> errorHandler) {

            string stringPayload = await Task.Run(() => JsonConvert.SerializeObject(Payload));
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient()) {
                httpClient.BaseAddress = CrearURL(url,version);
                httpClient.DefaultRequestHeaders.Add("api-version", version);
                httpClient.DefaultRequestHeaders.Add("Authorization", "bearer " + token);

                var httpResponse = await httpClient.PostAsync(endPoint, httpContent);

                switch (httpResponse.StatusCode) {
                    case HttpStatusCode.Unauthorized:
                        errorHandler("NO AUTORIZADO");
                        throw new Exception("NO AUTORIZADO");

                    case HttpStatusCode.OK:
                        if (httpResponse.Content != null) {
                            return await httpResponse.Content.ReadAsStringAsync();
                        } else {
                            return null;
                        }

                    case HttpStatusCode.BadRequest:
                        string resultadoError = await httpResponse.Content.ReadAsStringAsync();
                        try {
                            ErrorResponse error = JsonConvert.DeserializeObject<ErrorResponse>(resultadoError);
                            errorHandler(error.error.Msj);
                            throw new Exception(error.error.Msj);
                        } catch (Exception ex) {
                            return null;
                        }

                    default:
                        return null;

                }
            }
        }


        /// <summary>
        /// Consume la api recibiendo el tipo de objeto de consulta a enviar, y el tipo de objetos a recibir.
        /// Este metodo se usa cuando se recibe una lista de objetos de respuesta, ej: Ordenes, Solicitudes FCI, Boletos, etc
        /// </summary>
        /// <typeparam name="T">Tipo de dato de response</typeparam>
        /// <param name="Payload">objeto request con la consulta a realizar</param>
        /// <param name="endPoint">Metodo al que se llama de EscoApi</param>
        /// <param name="url">Url Base de EscoApi</param>
        /// <param name="version">Version de EscoApi a utilizar</param>
        /// <param name="token">Token de autenticacion</param>
        /// <param name="errorHandler">Funcion generica que se invoca si se produce un error</param>
        /// <returns></returns>
        public static async Task<List<T>> ConsumirMetodoGetGenerico<T>(string endPoint, string url, string version, string token, Func<string, int> errorHandler) {


            //se crea la conexion con EscoApi y se usa para procesar la respuesta
            using (var httpClient = new HttpClient()) {

                //se definen los encabezados del request
                httpClient.BaseAddress = CrearURL(url, version);
                httpClient.DefaultRequestHeaders.Add("api-version", version);
                httpClient.DefaultRequestHeaders.Add("Authorization", "bearer " + token);

                //se hace la llamada a EscoApi
                var httpResponse = await httpClient.GetAsync(endPoint);

                //proceso el estado de la respuesta de EscoApiTest de acuerdo a su codigo
                switch (httpResponse.StatusCode) {

                    //no estoy autorizado a usar EscoApi (sebo autenticarme y usar un token valido)
                    case HttpStatusCode.Unauthorized:
                        errorHandler("NO AUTORIZADO");
                        throw new Exception("NO AUTORIZADO");

                    //el response el valido, se convierte la respuesta al tipo de objetos solicitado
                    case HttpStatusCode.OK:
                        string resultado = await httpResponse.Content.ReadAsStringAsync();
                        try {
                            return JsonConvert.DeserializeObject<List<T>>(resultado);
                        } catch (Exception ex) {
                            return null;
                        }

                    //si se genero un error se muestra el mensaje, llamando a una funcion generica de manejo de error que se pasa como parametro (errorHandler)
                    case HttpStatusCode.BadRequest:
                        string resultadoError = await httpResponse.Content.ReadAsStringAsync();
                        try {
                            ErrorResponse error = JsonConvert.DeserializeObject<ErrorResponse>(resultadoError);
                            errorHandler(error.error.Msj);
                            throw new Exception(error.error.Msj);
                        } catch (Exception ex) {
                            return null;
                        }

                    default:
                        return null;
                }
            }
        }


        /// <summary>
        /// Crea la url de EscoApi con la url base y la version
        /// </summary>
        /// <param name="url">Url Base de EscoApi</param>
        /// <param name="version">Version a utilizar</param>
        /// <returns></returns>
        public static Uri CrearURL(string url, string version) {
            return new Uri(url + "/v" + version + "/");
        }
    }
}
