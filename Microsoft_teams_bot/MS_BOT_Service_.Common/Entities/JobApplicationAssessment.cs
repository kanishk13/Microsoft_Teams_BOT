﻿//----------------------------------------------------------------------------
// <copyright company="Microsoft Corporation" file="JobApplicationAssessment.cs">
// Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
//----------------------------------------------------------------------------

namespace MS.GTA.BOTService.Common.Entities
{
    using MS.GTA.BOTService.Common.Enum;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class JobApplicationAssessment : DocDbEntity
    {
        [DataMember(Name = "JobApplicationAssessmentID", EmitDefaultValue = false, IsRequired = false)]
        public string JobApplicationAssessmentID { get; set; }

        [DataMember(Name = "StrengthComment", EmitDefaultValue = false, IsRequired = false)]
        public string StrengthComment { get; set; }

        [DataMember(Name = "WeaknessComment", EmitDefaultValue = false, IsRequired = false)]
        public string WeaknessComment { get; set; }

        [DataMember(Name = "OverallComment", EmitDefaultValue = false, IsRequired = false)]
        public string OverallComment { get; set; }

        [DataMember(Name = "Status", EmitDefaultValue = false, IsRequired = false)]
        public JobApplicationAssessmentStatus? Status { get; set; }

        [DataMember(Name = "StatusReason", EmitDefaultValue = false, IsRequired = false)]
        public JobApplicationAssessmentStatusReason? StatusReason { get; set; }

        [DataMember(Name = "IsRecommendedToContinue", EmitDefaultValue = false, IsRequired = false)]
        public bool? IsRecommendedToContinue { get; set; }

        [DataMember(Name = "JobApplication", EmitDefaultValue = false, IsRequired = false)]
        public JobApplication JobApplication { get; set; }

        [DataMember(Name = "JobApplicationParticipant", EmitDefaultValue = false, IsRequired = false)]
        public JobApplicationParticipant JobApplicationParticipant { get; set; }

        [DataMember(Name = "SubmittedDateTime", EmitDefaultValue = false, IsRequired = false)]
        public DateTime? SubmittedDateTime { get; set; }

        [DataMember(Name = "FeedbackProvidedBy", EmitDefaultValue = false, IsRequired = false)]
        public string FeedbackProvidedBy { get; set; }

        [DataMember(Name = "FileAttachments", EmitDefaultValue = false, IsRequired = false)]
        public IList<FileAttachmentInfoEntity> FileAttachments { get; set; }

    }
}
