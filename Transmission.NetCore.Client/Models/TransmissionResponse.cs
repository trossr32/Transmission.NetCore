using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Transmission.NetCore.Client.Models
{
    /// <summary>
	/// Transmission response 
	/// </summary>
	internal class TransmissionResponse : CommunicateBase
    {
        /// <summary>
        /// Contains "success" on success, or an error string on failure.
        /// </summary>
        [JsonProperty("result")]
        public string Result;
    }
}
