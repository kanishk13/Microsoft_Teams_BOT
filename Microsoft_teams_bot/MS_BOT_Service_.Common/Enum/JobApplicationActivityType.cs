//----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
//----------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace MS.GTA.BOTService.Common.Enum
{
    [DataContract(Namespace = "MS.GTA.TalentEngagement")]
    public enum JobApplicationActivityType
    {
        [EnumMember(Value = "IVRequested")]
        IVRequested = 0,

        [EnumMember(Value = "Interview")]
        Interview = 1,

        [EnumMember(Value = "Feedback")]
        Feedback = 2,

        [EnumMember(Value = "Offer")]
        Offer = 3        
    }
}
