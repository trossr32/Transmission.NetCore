using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Transmission.NetCore.Client.Models
{
    /// <summary>
	/// Transmission request 
	/// </summary>
	internal class TransmissionRequest : CommunicateBase
    {
        /// <summary>
        /// Name of the method to invoke
        /// </summary>
        [JsonProperty("method")]
        public string Method;

        public TransmissionRequest(string method, Dictionary<string, object> arguments)
        {
            this.Method = method;
            this.Arguments = arguments;
        }
    }
}
