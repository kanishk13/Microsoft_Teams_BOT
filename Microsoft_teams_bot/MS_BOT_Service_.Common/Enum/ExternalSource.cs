//----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
//----------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace MS.GTA.BOTService.Common.Enum
{
    [DataContract(Namespace = "MS.GTA.TalentEngagement")]
    public enum ExternalSource
    {
        [EnumMember(Value = "internal")]
        Internal = 0,
        [EnumMember(Value = "mSDataMall")]
        MSDataMall = 1,
        [EnumMember(Value = "linkedIn")]
        LinkedIn = 2,
        [EnumMember(Value = "greenhouse")]
        Greenhouse = 3,
        [EnumMember(Value = "iCIMS")]
        ICIMS = 4
    }
}
