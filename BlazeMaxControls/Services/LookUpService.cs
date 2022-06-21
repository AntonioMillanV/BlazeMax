using BlazeMaxControls.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using veXMAX.Data;
using veXMAX.Shared.Attributes;

namespace BlazeMaxControls.Services
{
	public class LookUpService
	{
		public HttpClient httpClient;
		public Uri baseUri;

		public LookUpService()
		{
			httpClient = new HttpClient();
			//baseUri = new Uri(configuration["FrogODataBaseUri"]);
			//TODO poner en configuracion del cliente
			baseUri = new Uri("https://localhost:44326/");
		}

		public async Task<T> Get<T>(string _PK)
		{
			string propURL = typeof(T).GetCustomAttributes(typeof(VXControllerPrimitiveAttribute), false).Cast<VXControllerPrimitiveAttribute>().ToList().FirstOrDefault().Route;
			//var uri = new Uri(baseUri, $"{typeName}/Get?JParams={{\"PROLNA_CODIGO_K\":'{HttpUtility.UrlEncode(_PK)}'}}");

			var uri = new Uri(baseUri, $"{propURL}/Get?JParams={_PK}");
			return await AnyGet<T>(uri);
		}

		public async Task<T> AnyGet<T>(Uri uri)
		{
			var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);
			try
			{
				var response = await httpClient.SendAsync(httpRequestMessage);
				if (response.IsSuccessStatusCode)
				{
					var content = await response.Content.ReadAsStringAsync();
					var result = JsonConvert.DeserializeObject<VXResponse<T>>(content);
					return result.Value;
				}
			}
			catch (Exception e)
			{
				//TODO verificar posibles errores
			}
			return default(T);
		}

		public async Task<List<T>> GetFull<T>(string filter, string orderby, int top, int skip, string select)
		{
            string propURL = typeof(T).GetCustomAttributes(typeof(VXControllerPrimitiveAttribute), false).Cast<VXControllerPrimitiveAttribute>().ToList().FirstOrDefault().Route;
            var uri = new Uri(baseUri, $"{propURL}/List");
			uri = uri.GetODataUri(filter: filter, top: top, skip: skip, orderby: orderby, expand: null, select: select, count: null);

			return await ODataGet<T>(uri);
		}

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
	}
}
