using MediatR;

namespace JhipsterExample.Application.Commands;

public class AccountResetPasswordCommand : IRequest<Unit>
{
    public string Mail { get; set; }
}
