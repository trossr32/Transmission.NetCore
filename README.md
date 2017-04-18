# Transmission.NetCore
.Net Core Transmission client library 

C# implementation of the Transmission RPC API for .Net CORE

| Command              | Not Implemented | Implemented|
| -------------------- |:-:|:-:|
| torrent-start        |   | x |
| torrent-start-now    |   | x |
| torrent-stop         |   | x |
| torrent-verify       |   | x |
| torrent-reannounce   |   | x |
| torrent-set          |   | x |
| torrent-get          |   | x |
| torrent-add          |   | x |
| torrent-remove       |   | x |
| torrent-set-location |   | x |
| torrent-rename-path  |   | x |
| session-set          |   | x |
| session-get          |   | x |
| session-stats        |   | x |
| blocklist-update     |   | x |
| port-test            |   | x |
| session-close        |   | x |
| queue-move-top       |   | x |
| queue-move-up        |   | x |
| queue-move-down      |   | x |
| queue-move-bottom    |   | x |
| free-space           |   | x |

How to use
-------------

Install Nuget Package: `PM> Install-Package Transmission.API.RPC`

```C#
//Add using Transmission.API.RPC;

//Create TransmissionClient (set host, optional session id,optional login and optional pass).
TransmissionClient client = new TransmissionClient("HOST", "PARAM_SESSION_ID", "PARAM_LOGIN", "PARAM_PASS");

//After initialization, client can call methods:
var sessionInfo = await client.SessionGetAsync();
var allTorrents = await client.TorrentGetAsync(TorrentFields.ALL_FIELDS);
//<...>
```
