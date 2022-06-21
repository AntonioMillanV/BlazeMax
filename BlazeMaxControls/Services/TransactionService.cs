using BlazeMaxControls.Helpers;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using veXMAX.Data;
using veXMAX.Data.Helpers;

namespace BlazeMaxControls.Services
{
    public class TransactionService
    {
        public HttpClient httpClient;
        public Uri baseUri;

        public TransactionService(IConfiguration configuration)
        {
            httpClient = new HttpClient();
            //baseUri = new Uri(configuration["FrogODataBaseUri"]);
            //TODO poner en configuracion del cliente
            baseUri = new Uri("https://localhost:44326/api/vxtra/");
        }

        // Para cuando se usa OData
        public async Task<List<T>> ODataGet<T>(Uri uri)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);
            try
            {
                var response = await httpClient.SendAsync(httpRequestMessage);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<VXResponse<List<T>>>(content);
                    return result?.Value;
                }
            }
            catch (Exception e)
            {
                //TODO verificar posibles errores
            }
            return default;
        }

        public async Task<List<T>> GetFull<T>(string filter, string orderby, int top, int skip)
        {
            var typeName = typeof(T).Name;
            var uri = new Uri(baseUri, $"{typeName}/GetFull");
            uri = uri.GetODataUri(filter: filter, top: top, skip: skip, orderby: orderby, expand: null, select: null, count: null);

            return await ODataGet<T>(uri);
        }

        public async Task<int> Delete<T>(Object _PK)
        {
            var typeName = typeof(T).Name;
            //var uri = new Uri(baseUri, $"{typeName}('{HttpUtility.UrlEncode(_PK)}')");
            var uri = new Uri(baseUri, $"{typeName}('{_PK}')");
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            var response = await httpClient.SendAsync(httpRequestMessage);
            return response.IsSuccessStatusCode ? 0 : -1;
        }

        public Task ExcelImportAsync(Stream ms)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> ExcelTemplateAsync(string filter, string orderby, int top, int skip)
        {
            throw new NotImplementedException();
        }

        public async Task<T> First<T>() where T : new()
        {
            var typeName = typeof(T).Name;
            var uri = new Uri(baseUri, $"{typeName}/GetFull");
            VXODataHelper<T>.First(out var filter, out var @orderby, out var top);
            uri = uri.GetODataUri(filter: filter, top: top, skip: null, orderby: orderby, expand: null, select: null, count: null);
            var ret = (await ODataGet<T>(uri));
            return ret != null ? ret[0] : default(T);
        }

        public async Task<T> Last<T>() where T : new()
        {
            var typeName = typeof(T).Name;
            var uri = new Uri(baseUri, $"{typeName}/GetFull");
            VXODataHelper<T>.Last(out var filter, out var @orderby, out var top);
            uri = uri.GetODataUri(filter: filter, top: top, skip: null, orderby: orderby, expand: null, select: null, count: null);
            var ret = (await ODataGet<T>(uri));
            return ret != null ? ret[0] : default(T);
        }

        public async Task<T> Next<T>(Object _PK) where T : new()
        {
            var typeName = typeof(T).Name;
            var uri = new Uri(baseUri, $"{typeName}/GetFull");
            VXODataHelper<T>.Next(new object[] { _PK }, out var filter, out var @orderby, out var top);
            uri = uri.GetODataUri(filter: filter, top: top, skip: null, orderby: orderby, expand: null, select: null, count: null);
            var ret = (await ODataGet<T>(uri));
            return ret != null ? ret[0] : default(T);
        }

        public async Task<T> Prior<T>(Object _PK) where T : new()
        {
            var typeName = typeof(T).Name;
            var uri = new Uri(baseUri, $"{typeName}/GetFull");
            VXODataHelper<T>.Prior(new object[] { _PK }, out var filter, out var @orderby, out var top);
            uri = uri.GetODataUri(filter: filter, top: top, skip: null, orderby: orderby, expand: null, select: null, count: null);
            var ret = (await ODataGet<T>(uri));
            return ret != null ? ret[0] : default(T);
        }

    }
}
