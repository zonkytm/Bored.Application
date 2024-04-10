using Bored.Application.Api.Activities.Controllers;
using Bored.Application.Api.Activities.Requests;
using Bored.Application.Api.Activities.Responces;
using Bored.Application.AppServices.Contracts.Activities.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace Bored.Application.Host.Activities.ActivityControllers;

[Route("api/[controller]")]
[ApiController]
public class ActivityController : IActivityController
{
    private readonly IGetActivityHandler _getActivityHandler;

    public ActivityController(IGetActivityHandler getActivityHandler)
    {
        _getActivityHandler = getActivityHandler;
    }

    [HttpGet("getActivity")]
    public async Task<GetActivityResponse> GetActivity([FromQuery] GetActivityRequest getActivityRequest )
    {

        if (getActivityRequest == null)
        {
            throw new NullReferenceException();
        }
        
        var response = await _getActivityHandler.Handle(getActivityRequest);

        return response;
    }
}