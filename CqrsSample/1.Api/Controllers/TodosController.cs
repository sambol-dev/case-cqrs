using CqrsSample.Application.Todos.Commands;
using CqrsSample.Application.Todos.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsSample.Api.Controllers;

[ApiController]
[Route("api/todos")]
public sealed class TodosController(IMediator mediator) : ControllerBase
{
    [HttpPost("{id:guid}/complete")]
    public async Task<IActionResult> Complete(Guid id, CancellationToken cancellationToken)
    {
        var result = await mediator.Send(
            new CompleteTodoCommand(id),
            cancellationToken);

        if (result.IsFailure)
            return BadRequest(result.Error);

        return Ok();
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(
        Guid id,
        CancellationToken cancellationToken)
    {
        var result = await mediator.Send(
            new GetTodoQuery(id),
            cancellationToken);

        if (result.IsFailure)
            return NotFound(result.Error);

        return Ok(result.Value);
    }
}