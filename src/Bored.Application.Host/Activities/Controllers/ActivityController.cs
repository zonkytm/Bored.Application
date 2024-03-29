using Bored.Application.Api;
using Bored.Application.Api.Activities.Responces;
using Bored.Application.Host.HttpClients;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bored.Application.Host.Activities.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IBoredService _boredService;

        public ActivityController(IBoredService boredService)
        {
            _boredService = boredService;
        }

        [HttpGet("get")]
        public async Task<ActivityModel> GetActivity()
        {
        
            var activity = _boredService.GetActivity(new Api.Activities.Requests.GetActivityRequest()).GetAwaiter().GetResult();
          
            return activity;
        }

    }
}
