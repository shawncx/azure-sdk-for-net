// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using Azure;
    using Search;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Removes words that are too long or too short. This token filter is
    /// implemented using Apache Lucene.
    /// <see href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/LengthFilter.html" />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Azure.Search.LengthTokenFilter")]
    public partial class LengthTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the LengthTokenFilter class.
        /// </summary>
        public LengthTokenFilter() { }

        /// <summary>
        /// Initializes a new instance of the LengthTokenFilter class.
        /// </summary>
        /// <param name="name">The name of the token filter. It must only
        /// contain letters, digits, spaces, dashes or underscores, can only
        /// start and end with alphanumeric characters, and is limited to 128
        /// characters.</param>
        /// <param name="min">The minimum length in characters. Default is 0.
        /// Maximum is 300. Must be less than the value of max.</param>
        /// <param name="max">The maximum length in characters. Default and
        /// maximum is 300.</param>
        public LengthTokenFilter(string name, int? min = default(int?), int? max = default(int?))
            : base(name)
        {
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Gets or sets the minimum length in characters. Default is 0.
        /// Maximum is 300. Must be less than the value of max.
        /// </summary>
        [JsonProperty(PropertyName = "min")]
        public int? Min { get; set; }

        /// <summary>
        /// Gets or sets the maximum length in characters. Default and maximum
        /// is 300.
        /// </summary>
        [JsonProperty(PropertyName = "max")]
        public int? Max { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Min > 300)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Min", 300);
            }
            if (Max > 300)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Max", 300);
            }
        }
    }
}
