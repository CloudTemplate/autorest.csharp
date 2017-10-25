// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.AcceptanceTestsPaging.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Additional parameters for a set of operations, such as: Paging_GetMultiplePagesFragmentWithGroupingNextLink,
    /// Paging_NextFragmentWithGrouping.
    /// </summary>
    public partial class CustomParameterGroup
    {
        /// <summary>
        /// Initializes a new instance of the CustomParameterGroup class.
        /// </summary>
        public CustomParameterGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomParameterGroup class.
        /// </summary>
        /// <param name="apiVersion">Sets the api version to use.</param>
        /// <param name="tenant">Sets the tenant to use.</param>
        public CustomParameterGroup(string apiVersion, string tenant)
        {
            ApiVersion = apiVersion;
            Tenant = tenant;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets sets the api version to use.
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets sets the tenant to use.
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public string Tenant { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref='ValidationException'>
        /// Thrown when validation fails.
        /// </exception>
        public virtual void Validate()
        {
            if (ApiVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApiVersion");
            }
            if (Tenant == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tenant");
            }
        }
    }
}
