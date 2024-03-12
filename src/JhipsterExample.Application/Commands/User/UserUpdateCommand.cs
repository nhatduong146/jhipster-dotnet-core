using JhipsterExample.Domain.Entities;
using MediatR;
using JhipsterExample.Dto;

namespace JhipsterExample.Application.Commands;

public class UserUpdateCommand : IRequest<User>
{
    public UserDto UserDto { get; set; }
}
