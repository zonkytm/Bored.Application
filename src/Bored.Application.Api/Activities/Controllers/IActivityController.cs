using Bored.Application.Api.Activities.Requests;
using Bored.Application.Api.Activities.Responces;

namespace Bored.Application.Api.Activities.Controllers
{
    public interface IActivityController
    {
        Task<GetActivityResponse> GetActivity(GetActivityRequest getActivityRequest);
    }
}