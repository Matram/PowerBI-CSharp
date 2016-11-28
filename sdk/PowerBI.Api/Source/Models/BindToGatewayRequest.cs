// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V1.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// The Bind dataset to gateway request
    /// </summary>
    public partial class BindToGatewayRequest
    {
        /// <summary>
        /// Initializes a new instance of the BindToGatewayRequest class.
        /// </summary>
        public BindToGatewayRequest() { }

        /// <summary>
        /// Initializes a new instance of the BindToGatewayRequest class.
        /// </summary>
        public BindToGatewayRequest(string gatewayObjectId = default(string))
        {
            GatewayObjectId = gatewayObjectId;
        }

        /// <summary>
        /// The gateway id
        /// </summary>
        [JsonProperty(PropertyName = "gatewayObjectId")]
        public string GatewayObjectId { get; set; }

    }
}
