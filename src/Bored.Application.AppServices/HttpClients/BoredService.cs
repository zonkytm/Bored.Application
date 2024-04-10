using System.Net.Http.Json;
using Bored.Application.Api;
using Bored.Application.Api.Activities.Requests;
using Bored.Application.Appservices.Contracts.Activities.Infos;

namespace Bored.Application.AppServices.HttpClients
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

        public async Task<GetActivityInfo> GetActivityAsync(GetActivityRequest request)
        {
            var query = "?type=social";

            var activityResponce = await _httpClient.GetAsync(_url + query);

            if (!activityResponce.IsSuccessStatusCode)
            {
                throw new Exception("Апи недоступно");
            }

            var activity = await activityResponce.Content.ReadFromJsonAsync<GetActivityInfo>();

            return activity;
        }

    }
}
