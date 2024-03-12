using MediatR;
using JhipsterExample.Dto;
using System.Security.Claims;

namespace JhipsterExample.Application.Commands;

public class AccountSaveCommand : IRequest<Unit>
{
    public ClaimsPrincipal User { get; set; }
    public UserDto UserDto { get; set; }
}
