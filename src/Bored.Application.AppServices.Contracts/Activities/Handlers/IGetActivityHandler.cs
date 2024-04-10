using Bored.Application.Api.Activities.Requests;
using Bored.Application.Api.Activities.Responces;
using Bored.Application.Appservices.Contracts.Activities.Infos;

namespace Bored.Application.AppServices.Contracts.Activities.Handlers;

public interface IGetActivityHandler
{
    Task<GetActivityResponse> Handle(GetActivityRequest request);
}