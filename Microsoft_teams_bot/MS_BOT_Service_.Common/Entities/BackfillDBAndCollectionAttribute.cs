﻿//----------------------------------------------------------------------------
// <copyright company="Microsoft Corporation" file="PartitionKeyPathAttribute.cs">
// Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
//----------------------------------------------------------------------------

namespace MS.GTA.BOTService.Common.Entities
{
    using System;

    /// <summary>
    /// Attribute to specify the collection partition key path.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class PartitionKeyPathAttribute : Attribute
    {
        /// <summary>Initializes a new instance of the <see cref="PartitionKeyPathAttribute"/> class.</summary>
        /// <param name="path">The path.</param>
        public PartitionKeyPathAttribute(string path)
        {
            this.Path = path;
        }

        /// <summary>Gets the path.</summary>
        public string Path { get; }
    }
}