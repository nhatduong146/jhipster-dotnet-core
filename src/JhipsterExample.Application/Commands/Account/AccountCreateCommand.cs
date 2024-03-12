using JhipsterExample.Domain.Entities;
using MediatR;
using JhipsterExample.Dto;

namespace JhipsterExample.Application.Commands;

public class AccountCreateCommand : IRequest<User>
{
    public ManagedUserDto ManagedUserDto { get; set; }
}
