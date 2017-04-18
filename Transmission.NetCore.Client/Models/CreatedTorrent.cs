using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Transmission.NetCore.Client.Models
{
    /// <summary>
	/// Information of added torrent
	/// </summary>
	public class CreatedTorrent
    {
        /// <summary>
        /// Torrent ID
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; set; }

        /// <summary>
        /// Torrent name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Torrent Hash
        /// </summary>
        [JsonProperty("hashString")]
        public string HashString { get; set; }

    }
}
