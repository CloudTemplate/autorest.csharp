// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.AcceptanceTestsPaging
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PagingOperations.
    /// </summary>
    public static partial class PagingOperationsExtensions
    {
        /// <summary>
        /// A paging operation that finishes on the first call without a nextlink
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IPage<Product> GetSinglePages(this IPagingOperations operations)
        {
            return operations.GetSinglePagesAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that finishes on the first call without a nextlink
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetSinglePagesAsync(this IPagingOperations operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetSinglePagesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetMultiplePagesOptions'>
        /// Additional parameters for the operation
        /// </param>
        public static IPage<Product> GetMultiplePages(this IPagingOperations operations, string clientRequestId = default(string), PagingGetMultiplePagesOptions pagingGetMultiplePagesOptions = default(PagingGetMultiplePagesOptions))
        {
            return operations.GetMultiplePagesAsync(clientRequestId, pagingGetMultiplePagesOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetMultiplePagesOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetMultiplePagesAsync(this IPagingOperations operations, string clientRequestId = default(string), PagingGetMultiplePagesOptions pagingGetMultiplePagesOptions = default(PagingGetMultiplePagesOptions), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetMultiplePagesWithHttpMessagesAsync(clientRequestId, pagingGetMultiplePagesOptions, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that includes a nextLink in odata format that has 10 pages
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetOdataMultiplePagesOptions'>
        /// Additional parameters for the operation
        /// </param>
        public static IPage<Product> GetOdataMultiplePages(this IPagingOperations operations, string clientRequestId = default(string), PagingGetOdataMultiplePagesOptions pagingGetOdataMultiplePagesOptions = default(PagingGetOdataMultiplePagesOptions))
        {
            return operations.GetOdataMultiplePagesAsync(clientRequestId, pagingGetOdataMultiplePagesOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that includes a nextLink in odata format that has 10 pages
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetOdataMultiplePagesOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetOdataMultiplePagesAsync(this IPagingOperations operations, string clientRequestId = default(string), PagingGetOdataMultiplePagesOptions pagingGetOdataMultiplePagesOptions = default(PagingGetOdataMultiplePagesOptions), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetOdataMultiplePagesWithHttpMessagesAsync(clientRequestId, pagingGetOdataMultiplePagesOptions, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='pagingGetMultiplePagesWithOffsetOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        public static IPage<Product> GetMultiplePagesWithOffset(this IPagingOperations operations, PagingGetMultiplePagesWithOffsetOptions pagingGetMultiplePagesWithOffsetOptions, string clientRequestId = default(string))
        {
            return operations.GetMultiplePagesWithOffsetAsync(pagingGetMultiplePagesWithOffsetOptions, clientRequestId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='pagingGetMultiplePagesWithOffsetOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetMultiplePagesWithOffsetAsync(this IPagingOperations operations, PagingGetMultiplePagesWithOffsetOptions pagingGetMultiplePagesWithOffsetOptions, string clientRequestId = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetMultiplePagesWithOffsetWithHttpMessagesAsync(pagingGetMultiplePagesWithOffsetOptions, clientRequestId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that fails on the first call with 500 and then retries and then get a response including a
        /// nextLink that has 10 pages
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IPage<Product> GetMultiplePagesRetryFirst(this IPagingOperations operations)
        {
            return operations.GetMultiplePagesRetryFirstAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that fails on the first call with 500 and then retries and then get a response including a
        /// nextLink that has 10 pages
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetMultiplePagesRetryFirstAsync(this IPagingOperations operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetMultiplePagesRetryFirstWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages, of which the 2nd call fails first with 500. The
        /// client should retry and finish all 10 pages eventually.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IPage<Product> GetMultiplePagesRetrySecond(this IPagingOperations operations)
        {
            return operations.GetMultiplePagesRetrySecondAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages, of which the 2nd call fails first with 500. The
        /// client should retry and finish all 10 pages eventually.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetMultiplePagesRetrySecondAsync(this IPagingOperations operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetMultiplePagesRetrySecondWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that receives a 400 on the first call
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IPage<Product> GetSinglePagesFailure(this IPagingOperations operations)
        {
            return operations.GetSinglePagesFailureAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that receives a 400 on the first call
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetSinglePagesFailureAsync(this IPagingOperations operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetSinglePagesFailureWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that receives a 400 on the second call
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IPage<Product> GetMultiplePagesFailure(this IPagingOperations operations)
        {
            return operations.GetMultiplePagesFailureAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that receives a 400 on the second call
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetMultiplePagesFailureAsync(this IPagingOperations operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetMultiplePagesFailureWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that receives an invalid nextLink
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IPage<Product> GetMultiplePagesFailureUri(this IPagingOperations operations)
        {
            return operations.GetMultiplePagesFailureUriAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that receives an invalid nextLink
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetMultiplePagesFailureUriAsync(this IPagingOperations operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetMultiplePagesFailureUriWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='apiVersion'>
        /// Sets the api version to use.
        /// </param>
        /// <param name='tenant'>
        /// Sets the tenant to use.
        /// </param>
        public static IPage<Product> GetMultiplePagesFragmentNextLink(this IPagingOperations operations, string apiVersion, string tenant)
        {
            return operations.GetMultiplePagesFragmentNextLinkAsync(apiVersion, tenant).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='apiVersion'>
        /// Sets the api version to use.
        /// </param>
        /// <param name='tenant'>
        /// Sets the tenant to use.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetMultiplePagesFragmentNextLinkAsync(this IPagingOperations operations, string apiVersion, string tenant, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetMultiplePagesFragmentNextLinkWithHttpMessagesAsync(apiVersion, tenant, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment with parameters grouped
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='customParameterGroup'>
        /// Additional parameters for the operation
        /// </param>
        public static IPage<Product> GetMultiplePagesFragmentWithGroupingNextLink(this IPagingOperations operations, CustomParameterGroup customParameterGroup)
        {
            return operations.GetMultiplePagesFragmentWithGroupingNextLinkAsync(customParameterGroup).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment with parameters grouped
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='customParameterGroup'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetMultiplePagesFragmentWithGroupingNextLinkAsync(this IPagingOperations operations, CustomParameterGroup customParameterGroup, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetMultiplePagesFragmentWithGroupingNextLinkWithHttpMessagesAsync(customParameterGroup, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='apiVersion'>
        /// Sets the api version to use.
        /// </param>
        /// <param name='tenant'>
        /// Sets the tenant to use.
        /// </param>
        /// <param name='nextLink'>
        /// Next link for list operation.
        /// </param>
        public static IPage<Product> NextFragment(this IPagingOperations operations, string apiVersion, string tenant, string nextLink)
        {
            return operations.NextFragmentAsync(apiVersion, tenant, nextLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='apiVersion'>
        /// Sets the api version to use.
        /// </param>
        /// <param name='tenant'>
        /// Sets the tenant to use.
        /// </param>
        /// <param name='nextLink'>
        /// Next link for list operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> NextFragmentAsync(this IPagingOperations operations, string apiVersion, string tenant, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.NextFragmentWithHttpMessagesAsync(apiVersion, tenant, nextLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextLink'>
        /// Next link for list operation.
        /// </param>
        /// <param name='customParameterGroup'>
        /// Additional parameters for the operation
        /// </param>
        public static IPage<Product> NextFragmentWithGrouping(this IPagingOperations operations, string nextLink, CustomParameterGroup customParameterGroup)
        {
            return operations.NextFragmentWithGroupingAsync(nextLink, customParameterGroup).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that doesn't return a full URL, just a fragment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextLink'>
        /// Next link for list operation.
        /// </param>
        /// <param name='customParameterGroup'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> NextFragmentWithGroupingAsync(this IPagingOperations operations, string nextLink, CustomParameterGroup customParameterGroup, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.NextFragmentWithGroupingWithHttpMessagesAsync(nextLink, customParameterGroup, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that finishes on the first call without a nextlink
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static IPage<Product> GetSinglePagesNext(this IPagingOperations operations, string nextPageLink)
        {
            return operations.GetSinglePagesNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that finishes on the first call without a nextlink
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetSinglePagesNextAsync(this IPagingOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetSinglePagesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetMultiplePagesOptions'>
        /// Additional parameters for the operation
        /// </param>
        public static IPage<Product> GetMultiplePagesNext(this IPagingOperations operations, string nextPageLink, string clientRequestId = default(string), PagingGetMultiplePagesOptions pagingGetMultiplePagesOptions = default(PagingGetMultiplePagesOptions))
        {
            return operations.GetMultiplePagesNextAsync(nextPageLink, clientRequestId, pagingGetMultiplePagesOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetMultiplePagesOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetMultiplePagesNextAsync(this IPagingOperations operations, string nextPageLink, string clientRequestId = default(string), PagingGetMultiplePagesOptions pagingGetMultiplePagesOptions = default(PagingGetMultiplePagesOptions), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetMultiplePagesNextWithHttpMessagesAsync(nextPageLink, clientRequestId, pagingGetMultiplePagesOptions, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that includes a nextLink in odata format that has 10 pages
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetOdataMultiplePagesOptions'>
        /// Additional parameters for the operation
        /// </param>
        public static IPage<Product> GetOdataMultiplePagesNext(this IPagingOperations operations, string nextPageLink, string clientRequestId = default(string), PagingGetOdataMultiplePagesOptions pagingGetOdataMultiplePagesOptions = default(PagingGetOdataMultiplePagesOptions))
        {
            return operations.GetOdataMultiplePagesNextAsync(nextPageLink, clientRequestId, pagingGetOdataMultiplePagesOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that includes a nextLink in odata format that has 10 pages
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetOdataMultiplePagesOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetOdataMultiplePagesNextAsync(this IPagingOperations operations, string nextPageLink, string clientRequestId = default(string), PagingGetOdataMultiplePagesOptions pagingGetOdataMultiplePagesOptions = default(PagingGetOdataMultiplePagesOptions), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetOdataMultiplePagesNextWithHttpMessagesAsync(nextPageLink, clientRequestId, pagingGetOdataMultiplePagesOptions, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetMultiplePagesWithOffsetNextOptions'>
        /// Additional parameters for the operation
        /// </param>
        public static IPage<Product> GetMultiplePagesWithOffsetNext(this IPagingOperations operations, string nextPageLink, string clientRequestId = default(string), PagingGetMultiplePagesWithOffsetNextOptions pagingGetMultiplePagesWithOffsetNextOptions = default(PagingGetMultiplePagesWithOffsetNextOptions))
        {
            return operations.GetMultiplePagesWithOffsetNextAsync(nextPageLink, clientRequestId, pagingGetMultiplePagesWithOffsetNextOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='clientRequestId'>
        /// </param>
        /// <param name='pagingGetMultiplePagesWithOffsetNextOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetMultiplePagesWithOffsetNextAsync(this IPagingOperations operations, string nextPageLink, string clientRequestId = default(string), PagingGetMultiplePagesWithOffsetNextOptions pagingGetMultiplePagesWithOffsetNextOptions = default(PagingGetMultiplePagesWithOffsetNextOptions), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetMultiplePagesWithOffsetNextWithHttpMessagesAsync(nextPageLink, clientRequestId, pagingGetMultiplePagesWithOffsetNextOptions, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that fails on the first call with 500 and then retries and then get a response including a
        /// nextLink that has 10 pages
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static IPage<Product> GetMultiplePagesRetryFirstNext(this IPagingOperations operations, string nextPageLink)
        {
            return operations.GetMultiplePagesRetryFirstNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that fails on the first call with 500 and then retries and then get a response including a
        /// nextLink that has 10 pages
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetMultiplePagesRetryFirstNextAsync(this IPagingOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetMultiplePagesRetryFirstNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages, of which the 2nd call fails first with 500. The
        /// client should retry and finish all 10 pages eventually.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static IPage<Product> GetMultiplePagesRetrySecondNext(this IPagingOperations operations, string nextPageLink)
        {
            return operations.GetMultiplePagesRetrySecondNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that includes a nextLink that has 10 pages, of which the 2nd call fails first with 500. The
        /// client should retry and finish all 10 pages eventually.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetMultiplePagesRetrySecondNextAsync(this IPagingOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetMultiplePagesRetrySecondNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that receives a 400 on the first call
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static IPage<Product> GetSinglePagesFailureNext(this IPagingOperations operations, string nextPageLink)
        {
            return operations.GetSinglePagesFailureNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that receives a 400 on the first call
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetSinglePagesFailureNextAsync(this IPagingOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetSinglePagesFailureNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that receives a 400 on the second call
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static IPage<Product> GetMultiplePagesFailureNext(this IPagingOperations operations, string nextPageLink)
        {
            return operations.GetMultiplePagesFailureNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that receives a 400 on the second call
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetMultiplePagesFailureNextAsync(this IPagingOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetMultiplePagesFailureNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// A paging operation that receives an invalid nextLink
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static IPage<Product> GetMultiplePagesFailureUriNext(this IPagingOperations operations, string nextPageLink)
        {
            return operations.GetMultiplePagesFailureUriNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// A paging operation that receives an invalid nextLink
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<Product>> GetMultiplePagesFailureUriNextAsync(this IPagingOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetMultiplePagesFailureUriNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
