// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.AcceptanceTestsAzureSpecials
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ApiVersionLocalOperations.
    /// </summary>
    public static partial class ApiVersionLocalOperationsExtensions
    {
        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version = '2.0' to succeed
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static void GetMethodLocalValid(this IApiVersionLocalOperations operations)
        {
            operations.GetMethodLocalValidAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version = '2.0' to succeed
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task GetMethodLocalValidAsync(this IApiVersionLocalOperations operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.GetMethodLocalValidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version = null to succeed
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='apiVersion'>
        /// This should appear as a method parameter, use value null, this should result in no serialized parameter
        /// </param>
        public static void GetMethodLocalNull(this IApiVersionLocalOperations operations, string apiVersion = default(string))
        {
            operations.GetMethodLocalNullAsync(apiVersion).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version = null to succeed
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='apiVersion'>
        /// This should appear as a method parameter, use value null, this should result in no serialized parameter
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task GetMethodLocalNullAsync(this IApiVersionLocalOperations operations, string apiVersion = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.GetMethodLocalNullWithHttpMessagesAsync(apiVersion, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version = '2.0' to succeed
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static void GetPathLocalValid(this IApiVersionLocalOperations operations)
        {
            operations.GetPathLocalValidAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version = '2.0' to succeed
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task GetPathLocalValidAsync(this IApiVersionLocalOperations operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.GetPathLocalValidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version = '2.0' to succeed
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static void GetSwaggerLocalValid(this IApiVersionLocalOperations operations)
        {
            operations.GetSwaggerLocalValidAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get method with api-version modeled in the method.  pass in api-version = '2.0' to succeed
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task GetSwaggerLocalValidAsync(this IApiVersionLocalOperations operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.GetSwaggerLocalValidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

    }
}
