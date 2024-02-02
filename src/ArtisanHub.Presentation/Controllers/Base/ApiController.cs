using ArtisanHub.Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ArtisanHub.Presentation.Controllers.Base;

[ApiController]
public class ApiController(ISender sender) : ControllerBase
{
    protected IActionResult Test(Result result)
    {
        if (result.IsFailure)
            return BadRequest(result.Errors);

        return Ok(result);
    }
}