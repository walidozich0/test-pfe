﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 21-05-2025 19:14:54
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace BD.BloodCentral.Core
{
    public partial class BloodDonationPledge : EntityBase<Guid>, IAggregateRoot {

        public BloodDonationPledge()
        {
            OnCreated();
        }

        public Guid Id { get; set; }

        public BloodDonationPladgeEvolutionStatus EvolutionStatus { get; set; }

        public DateTime PledgeInitiatedDate { get; set; }

        public DateTime? PledgeDate { get; set; }

        public DateTime? PledgeHonoredOrCanceledDate { get; set; }

        public string PledgeNotes { get; set; }

        public string CantBeDoneReason { get; set; }

        public Guid BloodDonationRequestId { get; set; }

        public Guid DonorId { get; set; }

        public virtual BloodDonationRequest BloodDonationRequest { get; set; }

        public virtual Donor Donor { get; set; }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}
