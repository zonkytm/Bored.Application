using Bored.Application.Api;
using Bored.Application.Api.Activities.Requests;
using Bored.Application.Api.Activities.Responces;
using Bored.Application.AppServices.Contracts.Activities.Handlers;
using Bored.Application.AppServices.HttpClients;

namespace Bored.Application.AppServices.Activities.Handlers;

internal class GetActivityHandler : IGetActivityHandler
{
    private readonly IBoredService _boredService;
    
    public GetActivityHandler(IBoredService boredService)
    {
        _boredService = boredService;
    }

    public async Task<GetActivityResponse> Handle(GetActivityRequest request)
    {
        var activity = await _boredService.GetActivityAsync(request);

        var translatedActivity = new string("fd"); 
        
        var response = new GetActivityResponse();
        
        response.Activity = new ActivityModel
        {
            Activity = translatedActivity,
            Link = activity.Link,
            Key = activity.Key
        };

        return response;
    }
}