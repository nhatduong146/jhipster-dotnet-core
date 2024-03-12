using MediatR;
using JhipsterExample.Dto;

namespace JhipsterExample.Application.Commands;

public class AccountGetQuery : IRequest<UserDto>
{
}
