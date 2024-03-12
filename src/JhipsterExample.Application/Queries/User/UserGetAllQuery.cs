using JhipsterExample.Dto;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using JHipsterNet.Core.Pagination;
using MediatR;

namespace JhipsterExample.Application.Queries;

public class UserGetAllQuery : IRequest<(IHeaderDictionary, IEnumerable<UserDto>)>
{
    public IPageable Page { get; set; }
}
