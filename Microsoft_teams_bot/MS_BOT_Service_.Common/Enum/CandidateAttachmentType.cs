//----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
//----------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace MS.GTA.BOTService.Common.Enum
{
    [DataContract(Namespace = "MS.GTA.TalentEngagement")]
    public enum CandidateAttachmentType
    {
        [EnumMember(Value = "notSpecified")]
        NotSpecified = 0,
        [EnumMember(Value = "resume")]
        Resume = 1,
        [EnumMember(Value = "coverLetter")]
        CoverLetter = 2,
        [EnumMember(Value = "portfolio")]
        Portfolio = 3,
        [EnumMember(Value = "video")]
        Video = 4,
    }
}
