using Application.IntData.Common;
using Application.IntData.Queries.GetIntQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DataAPI;

public class IntDataController : ControllerBase
{
    //Logger, IMapper and repository
    private readonly IMediator Mediator;
    public IntDataController(IMediator mediator)
    {
        Mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllData()
    {
        //await repository call
        var command = new GetIntQuery();
        List<IntResponse> result = await Mediator.Send(command);
        return Ok(result);
    }

}
