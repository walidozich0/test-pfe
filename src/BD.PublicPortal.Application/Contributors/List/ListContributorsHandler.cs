﻿using BD.PublicPortal.Infrastructure.Services.Contibutors;
using BD.SharedKernel;

namespace BD.PublicPortal.Application.Contributors.List;

public class ListContributorsHandler(IListContributorsQueryService _query)
  : IQueryHandler<ListContributorsQuery, Result<IEnumerable<ContributorDTO>>>
{
  public async Task<Result<IEnumerable<ContributorDTO>>> Handle(ListContributorsQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync();

    return Result.Success(result);
  }
}
