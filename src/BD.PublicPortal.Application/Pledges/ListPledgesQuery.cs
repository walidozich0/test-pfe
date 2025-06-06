﻿using BD.PublicPortal.Core.DTOs;
using BD.PublicPortal.Core.Entities.Specifications;

namespace BD.PublicPortal.Application.Pledges;

public record ListPledgesQuery(BloodDonationPledgeSpecificationFilter? filter = null,
  Guid? LoggedUserID = null, int? Level = null)
  :IQuery<Result<IEnumerable<BloodDonationPledgeDTO>>>;
