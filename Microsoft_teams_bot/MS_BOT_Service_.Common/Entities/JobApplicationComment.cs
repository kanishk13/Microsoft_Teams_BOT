﻿using MS.GTA.BOTService.Common.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MS.GTA.BOTService.Common.Entities
{
    [DataContract]
    public class JobApplicationComment
    {
        [DataMember(Name = "JobApplicationCommentID", EmitDefaultValue = false, IsRequired = false)]
        public string JobApplicationCommentID { get; set; }

        [DataMember(Name = "Comment", EmitDefaultValue = false, IsRequired = false)]
        public string Comment { get; set; }

        [DataMember(Name = "OID", EmitDefaultValue = false, IsRequired = false)]
        public string OID { get; set; }

        [DataMember(Name = "CreatedDateTime", EmitDefaultValue = false, IsRequired = false)]
        public DateTime CreatedDateTime { get; set; }
    }
}
