using JhipsterExample.Dto;
using MediatR;

namespace JhipsterExample.Application.Queries;

public class UserGetQuery : IRequest<UserDto>
{
    public string Login { get; set; }
}
