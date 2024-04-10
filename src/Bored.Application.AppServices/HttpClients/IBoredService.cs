using Bored.Application.Api;
using Bored.Application.Api.Activities.Requests;
using Bored.Application.Appservices.Contracts.Activities.Infos;

namespace Bored.Application.AppServices.HttpClients
{
    public interface IBoredService
    {
        Task<GetActivityInfo> GetActivityAsync(GetActivityRequest request);
    }
}