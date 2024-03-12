using MediatR;
using JhipsterExample.Dto.Authentication;
using System.Security.Principal;

namespace JhipsterExample.Application.Commands;

public class UserJwtAuthorizeCommand : IRequest<IPrincipal>
{
    public LoginDto LoginDto { get; set; }
}
