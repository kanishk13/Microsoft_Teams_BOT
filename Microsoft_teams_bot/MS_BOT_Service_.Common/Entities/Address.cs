//----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
//----------------------------------------------------------------------------

namespace MS.GTA.BOTService.Common.Entities
{
    using MS.GTA.BOTService.Common.Enum;
    using System.Runtime.Serialization;

    [DataContract]
    public class Address
    {
        [DataMember(Name = "AddressLine1", IsRequired = false, EmitDefaultValue = false, Order = 0)]
        public string Line1 { get; set; }

        [DataMember(Name = "AddressLine2", IsRequired = false, EmitDefaultValue = false, Order = 1)]
        public string Line2 { get; set; }

        [DataMember(Name = "City", IsRequired = false, EmitDefaultValue = false, Order = 2)]
        public string City { get; set; }

        [DataMember(Name = "State", IsRequired = false, EmitDefaultValue = false, Order = 3)]
        public string State { get; set; }

        [DataMember(Name = "Country", IsRequired = false, EmitDefaultValue = false, Order = 4)]
        public CountryCode? Country { get; set; }

        [DataMember(Name = "PostalCode", IsRequired = false, EmitDefaultValue = false, Order = 5)]
        public string PostalCode { get; set; }
    }
}
