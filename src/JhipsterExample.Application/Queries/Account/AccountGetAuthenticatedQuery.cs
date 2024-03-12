using JhipsterExample.Domain.Entities;
using MediatR;
using JhipsterExample.Dto;
using System.Security.Claims;

namespace JhipsterExample.Application.Commands;

public class AccountGetAuthenticatedQuery : IRequest<string>
{
    public ClaimsPrincipal User { get; set; }
}
