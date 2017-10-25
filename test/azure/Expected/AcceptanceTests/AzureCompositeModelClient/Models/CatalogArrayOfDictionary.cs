// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.AcceptanceTestsAzureCompositeModelClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CatalogArrayOfDictionary
    {
        /// <summary>
        /// Initializes a new instance of the CatalogArrayOfDictionary class.
        /// </summary>
        public CatalogArrayOfDictionary()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets array of dictionary of products
        /// </summary>
        [JsonProperty(PropertyName = "productArrayOfDictionary")]
        public IList<IDictionary<string, Product>> ProductArrayOfDictionary { get; set; }

    }
}
