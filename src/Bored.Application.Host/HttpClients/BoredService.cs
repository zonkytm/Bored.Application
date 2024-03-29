using Bored.Application.Api.Activities.Requests;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Diagnostics;

namespace Bored.Application.Host.HttpClients
{
    public class BoredService : IBoredService
    {
        private readonly string _url;
        private readonly HttpClient _httpClient;
        public BoredService(HttpClient httpClient)
        {
            _url = "https://www.boredapi.com/api/activity";
            _httpClient = httpClient;

        }

        public async Task<Api.ActivityModel> GetActivity(GetActivityRequest request)
        {
            var query = "?type=social";

            var activityResponce = await _httpClient.GetAsync(_url);

            if (!activityResponce.IsSuccessStatusCode)
            {
                throw new Exception("Апи недоступно");
            }

            var activity = await activityResponce.Content.ReadFromJsonAsync<Api.ActivityModel>();

            return activity;
        }

    }
}
