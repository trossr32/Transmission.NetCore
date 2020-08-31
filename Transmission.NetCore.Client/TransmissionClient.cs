using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Flurl.Http;
using Transmission.NetCore.Client.Models;

namespace Transmission.NetCore.Client
{
    public class TransmissionClient
    {
        private string Host { get; set; }
        private string SessionId { get; set; }
        private string Login { get; set; }
        private string Password { get; set; }
        private int CurrentTag { get; set; }

        private readonly bool _needAuthorization;

        /// <summary>
		/// Initialize client
		/// </summary>
		/// <param name="host">Host address</param>
		/// <param name="sessionId">Session id</param>
		/// <param name="login">Login</param>
		/// <param name="password">Password</param>
		public TransmissionClient(string host, string sessionId = null, string login = null, string password = null)
        {
            Host = host;
            SessionId = sessionId;
            Login = login;
            Password = password;

            _needAuthorization = !string.IsNullOrWhiteSpace(login);
        }

        #region Session

        /// <summary>
        /// Close current session (API: session-close)
        /// </summary>
        public async void SessionCloseAsync()
        {
            var request = new TransmissionRequest("session-close", null);
            
            await SendRequestAsync(request);
        }

        /// <summary>
        /// Set information to current session (API: session-set)
        /// </summary>
        /// <param name="settings">New session settings</param>
        public async void SessionSetAsync(SessionSettings settings)
        {
            var request = new TransmissionRequest("session-set", settings.ToDictionary());
            
            await SendRequestAsync(request);
        }

        /// <summary>
        /// Get session statistic
        /// </summary>
        /// <returns>Session stat</returns>
        public async Task<Statistic> SessionGetStatisticAsync()
        {
            var request = new TransmissionRequest("session-stats", null);
            TransmissionResponse response = await SendRequestAsync(request);
            
            return response.Deserialize<Statistic>();
        }

        /// <summary>
        /// Get information of current session (API: session-get)
        /// </summary>
        /// <returns>Session information</returns>
        public async Task<SessionInformation> SessionGetAsync()
        {
            var request = new TransmissionRequest("session-get", null);
            TransmissionResponse response = await SendRequestAsync(request);
            
            return response.Deserialize<SessionInformation>();
        }

        #endregion

        #region Torrents
        /// <summary>
        /// Add torrent (API: torrent-add)
        /// </summary>
        /// <param name="torrent"></param>
        /// <returns>Torrent info (ID, Name and HashString)</returns>
        public async Task<CreatedTorrent> TorrentAddAsync(NewTorrent torrent)
        {
            if (string.IsNullOrWhiteSpace(torrent.MetaInfo) && string.IsNullOrWhiteSpace(torrent.Filename))
                throw new Exception("Either \"filename\" or \"metainfo\" must be included.");

            var request = new TransmissionRequest("torrent-add", torrent.ToDictionary());

            TransmissionResponse response = await SendRequestAsync(request);

            JObject jObject = response.Deserialize<JObject>();

            if (jObject?.First == null)
                return null;

            if (jObject.TryGetValue("torrent-duplicate", out JToken value))
                return JsonConvert.DeserializeObject<CreatedTorrent>(value.ToString());
            
            if (jObject.TryGetValue("torrent-added", out value))
                return JsonConvert.DeserializeObject<CreatedTorrent>(value.ToString());

            return null;
        }

        /// <summary>
        /// Set torrent params (API: torrent-set)
        /// </summary>
        /// <param name="settings">New torrent params</param>
        public async void TorrentSetAsync(TorrentSettings settings)
        {
            var request = new TransmissionRequest("torrent-set", settings.ToDictionary());
            
            await SendRequestAsync(request);
        }

        /// <summary>
        /// Get fields of torrents from ids (API: torrent-get)
        /// </summary>
        /// <param name="fields">Fields of torrents</param>
        /// <param name="ids">IDs of torrents (null or empty for get all torrents)</param>
        /// <returns>Torrents info</returns>
        public async Task<Torrents> TorrentGetAsync(string[] fields, params int[] ids)
        {
            var arguments = new Dictionary<string, object>
            {
                { "fields", fields }
            };

            if (ids != null && ids.Length > 0)
                arguments.Add("ids", ids);

            var request = new TransmissionRequest("torrent-get", arguments);

            var response = await SendRequestAsync(request);
            
            return response.Deserialize<Torrents>();
        }

        /// <summary>
        /// Remove torrents
        /// </summary>
        /// <param name="ids">Torrents id</param>
        /// <param name="deleteData">Remove local data</param>
        public async void TorrentRemoveAsync(int[] ids, bool deleteData = false)
        {
            var arguments = new Dictionary<string, object>
            {
                { "ids", ids },
                { "delete-local-data", deleteData }
            };

            var request = new TransmissionRequest("torrent-remove", arguments);
            
            await SendRequestAsync(request);
        }

        /// <summary>
        /// Start torrents (API: torrent-start)
        /// </summary>
        /// <param name="ids">Torrents id</param>
        public async void TorrentStartAsync(int[] ids)
        {
            var arguments = new Dictionary<string, object>
            {
                { "ids", ids }
            };

            var request = new TransmissionRequest("torrent-start", arguments);
            
            await SendRequestAsync(request);
        }

        /// <summary>
        /// Start now torrents (API: torrent-start-now)
        /// </summary>
        /// <param name="ids">Torrents id</param>
        public async void TorrentStartNowAsync(int[] ids)
        {
            var arguments = new Dictionary<string, object>
            {
                { "ids", ids }
            };

            var request = new TransmissionRequest("torrent-start-now", arguments);
            
            await SendRequestAsync(request);
        }

        /// <summary>
        /// Stop torrents (API: torrent-stop)
        /// </summary>
        /// <param name="ids">Torrents id</param>
        public async void TorrentStopAsync(int[] ids)
        {
            var arguments = new Dictionary<string, object>
            {
                { "ids", ids }
            };

            var request = new TransmissionRequest("torrent-stop", arguments);
            
            await SendRequestAsync(request);
        }

        /// <summary>
        /// Verify torrents (API: torrent-verify)
        /// </summary>
        /// <param name="ids">Torrents id</param>
        public async void TorrentVerifyAsync(int[] ids)
        {
            var arguments = new Dictionary<string, object>
            {
                { "ids", ids }
            };

            var request = new TransmissionRequest("torrent-verify", arguments);
            
            await SendRequestAsync(request);
        }

        /// <summary>
        /// Move torrents in queue on top (API: queue-move-top)
        /// </summary>
        /// <param name="ids">Torrents id</param>
        public async void TorrentQueueMoveTopAsync(int[] ids)
        {
            var arguments = new Dictionary<string, object>
            {
                { "ids", ids }
            };

            var request = new TransmissionRequest("queue-move-top", arguments);
            
            await SendRequestAsync(request);
        }

        /// <summary>
        /// Move up torrents in queue (API: queue-move-up)
        /// </summary>
        /// <param name="ids"></param>
        public async void TorrentQueueMoveUpAsync(int[] ids)
        {
            var arguments = new Dictionary<string, object>
            {
                { "ids", ids }
            };

            var request = new TransmissionRequest("queue-move-up", arguments);
            
            await SendRequestAsync(request);
        }

        /// <summary>
        /// Move down torrents in queue (API: queue-move-down)
        /// </summary>
        /// <param name="ids"></param>
        public async void TorrentQueueMoveDownAsync(int[] ids)
        {
            var arguments = new Dictionary<string, object>
            {
                { "ids", ids }
            };

            var request = new TransmissionRequest("queue-move-down", arguments);
            
            await SendRequestAsync(request);
        }

        /// <summary>
        /// Move torrents to bottom in queue  (API: queue-move-bottom)
        /// </summary>
        /// <param name="ids"></param>
        public async void TorrentQueueMoveBottomAsync(int[] ids)
        {
            var arguments = new Dictionary<string, object>
            {
                { "ids", ids }
            };

            var request = new TransmissionRequest("queue-move-bottom", arguments);
            
            await SendRequestAsync(request);
        }

        /// <summary>
        /// Set new location for torrents files (API: torrent-set-location)
        /// </summary>
        /// <param name="ids">Torrent ids</param>
        /// <param name="location">The new torrent location</param>
        /// <param name="move">Move from previous location</param>
        public async void TorrentSetLocationAsync(int[] ids, string location, bool move)
        {
            var arguments = new Dictionary<string, object>
            {
                { "ids", ids },
                { "location", location },
                { "move", move }
            };

            var request = new TransmissionRequest("torrent-set-location", arguments);
            
            await SendRequestAsync(request);
        }

        /// <summary>
        /// Rename a file or directory in a torrent (API: torrent-rename-path)
        /// </summary>
        /// <param name="id">The torrent whose path will be renamed</param>
        /// <param name="path">The path to the file or folder that will be renamed</param>
        /// <param name="name">The file or folder's new name</param>
        public async Task<RenamedTorrent> TorrentRenamePathAsync(int id, string path, string name)
        {
            var arguments = new Dictionary<string, object>
            {
                { "ids", new[] { id } },
                { "path", path },
                { "name", name }
            };

            var request = new TransmissionRequest("torrent-rename-path", arguments);
            
            TransmissionResponse response = await SendRequestAsync(request);

            return response.Deserialize<RenamedTorrent>();
        }
        #endregion

        #region System

        /// <summary>
        /// See if your incoming peer port is accessible from the outside world (API: port-test)
        /// </summary>
        /// <returns>Accessible state</returns>
        public async Task<bool> PortTestAsync()
        {
            var request = new TransmissionRequest("port-test", null);

            TransmissionResponse response = await SendRequestAsync(request);

            JObject data = response.Deserialize<JObject>();
            
            return (bool)data.GetValue("port-is-open");
        }

        #endregion

        /// <summary>
        /// Perform the Transmission API request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private async Task<TransmissionResponse> SendRequestAsync(TransmissionRequest request)
        {
            TransmissionResponse result;

            request.Tag = ++CurrentTag;

            try
            {
                if (_needAuthorization)
                {
                    result = await Host
                        .WithBasicAuth(Login, Password)
                        .WithHeader("Accept", "application/json-rpc")
                        .WithHeader("X-Transmission-Session-Id", SessionId)
                        .PostJsonAsync(request)
                        .ReceiveJson<TransmissionResponse>();
                }
                else
                {
                    result = await Host
                        .WithHeader("Accept", "application/json-rpc")
                        .WithHeader("X-Transmission-Session-Id", SessionId)
                        .PostJsonAsync(request)
                        .ReceiveJson<TransmissionResponse>();
                }

                if (result.Result != "success")
                    throw new Exception(result.Result);
            }
            catch (FlurlHttpException e)
            {
                if (e.Call.Response.StatusCode != HttpStatusCode.Conflict)
                    throw;

                SessionId = e.Call.Response.GetHeaderValue("X-Transmission-Session-Id");

                if (SessionId == null)
                    throw new Exception("Session id error");

                // repeat request with retrieved session id
                result = await SendRequestAsync(request);
            }

            return result;
        }
    }
}
