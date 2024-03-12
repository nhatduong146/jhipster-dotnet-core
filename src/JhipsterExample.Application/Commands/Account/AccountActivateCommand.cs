using JhipsterExample.Domain.Entities;
using MediatR;

namespace JhipsterExample.Application.Commands;

public class AccountActivateCommand : IRequest<User>
{
    public string Key { get; set; }
}
