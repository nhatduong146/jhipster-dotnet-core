using MediatR;
using JhipsterExample.Dto.Authentication;

namespace JhipsterExample.Application.Commands;

public class AccountChangePasswordCommand : IRequest<Unit>
{
    public PasswordChangeDto PasswordChangeDto { get; set; }
}
