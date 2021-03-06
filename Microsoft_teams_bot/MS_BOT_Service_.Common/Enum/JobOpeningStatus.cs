//----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
//----------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace MS.GTA.BOTService.Common.Enum
{
    [DataContract(Namespace = "MS.GTA.TalentEngagement")]
    public enum JobOpeningStatus
    {
        [EnumMember(Value = "active")]
        Active = 0,
        [EnumMember(Value = "closed")]
        Closed = 1,
        [EnumMember(Value = "draft")]
        Draft = 2,
        [EnumMember(Value = "pendingForApproval")]
        PendingForApproval = 3,
        [EnumMember(Value = "approved")]
        Approved = 4,
        [EnumMember(Value = "rejected")]
        Rejected = 5,
    }
}
