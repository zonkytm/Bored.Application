using Bored.Application.Api;
using Bored.Application.Api.Activities.Requests;

namespace Bored.Application.Host.HttpClients
{
    public interface IBoredService
    {
        Task<ActivityModel> GetActivity(GetActivityRequest request);
    }
}