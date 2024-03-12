using MediatR;
using System.Collections.Generic;

namespace JhipsterExample.Application.Queries;

public class UserGetAuthoritiesQuery : IRequest<IEnumerable<string>>
{
}
