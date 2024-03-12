using JhipsterExample.Domain.Entities;
using MediatR;
using JhipsterExample.Dto;

namespace JhipsterExample.Application.Commands;

public class UserCreateCommand : IRequest<User>
{
    public UserDto UserDto { get; set; }
}
