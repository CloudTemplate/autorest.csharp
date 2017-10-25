// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsCustomBaseUri
{
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Test Infrastructure for AutoRest
    /// </summary>
    public partial interface IAutoRestParameterizedHostTestClient : System.IDisposable
    {
        /// <summary>
        /// Gets or sets the base URI of the service.
        /// </summary>

        /// <summary>
        /// Gets or sets JSON serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets JSON deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// A string value that is used as a global part of the parameterized host
        /// </summary>
        string Host { get; set; }


        /// <summary>
        /// Gets the IPaths.
        /// </summary>
        IPaths Paths { get; }

    }
}
