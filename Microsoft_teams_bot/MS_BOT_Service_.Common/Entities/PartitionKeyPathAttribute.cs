﻿//----------------------------------------------------------------------------
// <copyright company="Microsoft Corporation" file="PartitionKeyPathAttribute.cs">
// Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
//----------------------------------------------------------------------------

namespace MS.GTA.BOTService.Common.Entities
{
    using System;

    /// <summary>
    /// Attribute to indicate if the HCM document client will try to backfill the database and collection if it doesn't exist.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class BackfillDBAndCollectionAttribute : Attribute
    {
        /// <summary>Initializes a new instance of the <see cref="BackfillDBAndCollectionAttribute"/> class.</summary>
        /// <param name="backfill">Indicates if the HCM document client will try to backfill the database and collection if it doesn't exist.</param>
        public BackfillDBAndCollectionAttribute(bool backfill = false)
        {
            this.Backfill = backfill;
        }

        /// <summary>Gets a value indicating whether if the HCM document client will try to backfill the database and collection if it doesn't exist.</summary>
        public bool Backfill { get; }
    }
}