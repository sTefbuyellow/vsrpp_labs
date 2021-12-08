using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace bntu.vsrpp.kkirichuk.Core
{
    public class CurrencyController
    {
        private static readonly HttpClient HttpClient;

        static CurrencyController()
        {
            HttpClient = new HttpClient();
        }

        public async Task<Currency> getCurrency(long curId)
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://www.nbrb.by/api/exrates/currencies/" + curId);
            request.Method = HttpMethod.Get;
            string responseBody = "error";
            HttpResponseMessage response = await HttpClient.SendAsync(request).ConfigureAwait(false);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                HttpContent responseContent = response.Content;
                responseBody = await responseContent.ReadAsStringAsync();
            }

            return JsonSerializer.Deserialize<Currency>(responseBody);
        }

        public async Task<List<Rate>> getRates(string periodicity)
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://www.nbrb.by/api/exrates/rates?periodicity=" + periodicity);
            request.Method = HttpMethod.Get;
            string responseBody = "error";
            HttpResponseMessage response = await HttpClient.SendAsync(request).ConfigureAwait(false);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                HttpContent responseContent = response.Content;
                responseBody = await responseContent.ReadAsStringAsync();
            }

            return JsonSerializer.Deserialize<List<Rate>>(responseBody);
        }

        public async Task<List<RateShort>> getRateShorts(string startDate, string endDate, long curId)
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://www.nbrb.by/API/ExRates/Rates/Dynamics/" + curId + "?startDate=" +
                                         startDate + "&endDate=" + endDate);
            request.Method = HttpMethod.Get;

            string responseBody = "error";
            HttpResponseMessage response = await HttpClient.SendAsync(request).ConfigureAwait(false);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                HttpContent responseContent = response.Content;
                responseBody = await responseContent.ReadAsStringAsync();
            }
            return JsonSerializer.Deserialize<List<RateShort>>(responseBody);
        }

        public async Task<List<Currency>> getCurrencies()
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://www.nbrb.by/api/exrates/currencies/");
            request.Method = HttpMethod.Get;
            string responseBody = "error";
            HttpResponseMessage response = await HttpClient.SendAsync(request).ConfigureAwait(false);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                HttpContent responseContent = response.Content;
                responseBody = await responseContent.ReadAsStringAsync();
            }
            return JsonSerializer.Deserialize<List<Currency>>(responseBody);
        }
    }
}