using MediatR;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JHipsterNet.Core.Pagination;
using JHipsterNet.Core.Pagination.Extensions;
using JhipsterExample.Domain.Entities;
using JhipsterExample.Security;
using JhipsterExample.Domain.Services.Interfaces;
using JhipsterExample.Dto;
using JhipsterExample.Web.Extensions;
using JhipsterExample.Web.Rest.Utilities;
using JhipsterExample.Crosscutting.Constants;
using JhipsterExample.Crosscutting.Exceptions;
using JhipsterExample.Infrastructure.Web.Rest.Utilities;
using JhipsterExample.Application.Queries;
using JhipsterExample.Application.Commands;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JhipsterExample.Controllers;


[Route("api/users")]
[ApiController]
public class PublicUsersController : ControllerBase
{
    private readonly ILogger<UsersController> _log;
    private readonly IMediator _mediator;

    public PublicUsersController(ILogger<UsersController> log, IMediator mediator)
    {
        _log = log;
        _mediator = mediator;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserDto>>> GetAllPublicUsers(IPageable pageable)
    {
        _log.LogDebug("REST request to get a page of Users");
        (var headers, var userDtos) = await _mediator.Send(new UserGetAllPublicUsersQuery { Page = pageable });
        return Ok(userDtos).WithHeaders(headers);
    }

}
