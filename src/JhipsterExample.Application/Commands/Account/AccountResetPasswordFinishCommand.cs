using JhipsterExample.Domain.Entities;
using MediatR;
using JhipsterExample.Dto.Authentication;

namespace JhipsterExample.Application.Commands;

public class AccountResetPasswordFinishCommand : IRequest<User>
{
    public KeyAndPasswordDto KeyAndPasswordDto { get; set; }
}
