using Application.ExamStress.Handlers;
using Application.ExamStress.Handlers.Dtos;
using Application.ExamStress.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DataAPI.Controllers.ExamStress;

public class ExamStressController : ControllerBase
{
    private readonly IMediator Mediator;

    public ExamStressController(IMediator mediator)
    {
        Mediator = mediator;
    }

    [Route("/")]
    [HttpGet]
    public async Task<IActionResult> GetExamStressData()
    {
        GetStudentDataQuery query = new GetStudentDataQuery();
        List<StudentDataResult> result = await Mediator.Send(query);
        return Ok(result);
    }


}