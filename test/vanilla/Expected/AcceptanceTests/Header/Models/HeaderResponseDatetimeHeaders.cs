// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsHeader.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for responseDatetime operation.
    /// </summary>
    public partial class HeaderResponseDatetimeHeaders
    {
        /// <summary>
        /// Initializes a new instance of the HeaderResponseDatetimeHeaders class.
        /// </summary>
        public HeaderResponseDatetimeHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets response with header values "2010-01-01T12:34:56Z" or "0001-01-01T00:00:00Z"
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public System.DateTime? Value { get; set; }

    }
}
