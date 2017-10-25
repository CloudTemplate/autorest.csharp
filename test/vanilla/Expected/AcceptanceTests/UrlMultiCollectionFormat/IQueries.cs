// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsUrlMultiCollectionFormat
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Queries operations.
    /// </summary>
    public partial interface IQueries
    {
        /// <summary>
        /// Get a null array of string using the multi-array format
        /// </summary>
        /// <param name='arrayQuery'>
        /// a null array of string using the multi-array format
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='ErrorException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        Task<HttpOperationResponse> ArrayStringMultiNullWithHttpMessagesAsync(IList<string> arrayQuery = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get an empty array [] of string using the multi-array format
        /// </summary>
        /// <param name='arrayQuery'>
        /// an empty array [] of string using the multi-array format
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='ErrorException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        Task<HttpOperationResponse> ArrayStringMultiEmptyWithHttpMessagesAsync(IList<string> arrayQuery = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get an array of string ['ArrayQuery1', 'begin!*'();:@ &amp;=+$,/?#[]end' , null, ''] using the mult-array format
        /// </summary>
        /// <param name='arrayQuery'>
        /// an array of string ['ArrayQuery1', 'begin!*'();:@ &amp;=+$,/?#[]end' , null, ''] using the mult-array format
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref='ErrorException'>
        /// Thrown when the operation returned an invalid status code.
        /// </exception>
        Task<HttpOperationResponse> ArrayStringMultiValidWithHttpMessagesAsync(IList<string> arrayQuery = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
