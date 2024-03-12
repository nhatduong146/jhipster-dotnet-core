using JhipsterExample.Domain.Entities;
using MediatR;

namespace JhipsterExample.Application.Commands;

public class UserDeleteCommand : IRequest<Unit>
{
    public string Login { get; set; }
}
