namespace Transmission.NetCore.Client.Models
{
    public static class TorrentFields
    {
        /// <summary>
        /// activityDate
        /// </summary>
        private const string ACTIVITY_DATE = "activityDate";

        /// <summary>
        /// addedDate
        /// </summary>
        private const string ADDED_DATE = "addedDate";

        /// <summary>
        /// bandwidthPriority
        /// </summary>
        private const string BANDWIDTH_PRIORITY = "bandwidthPriority";

        /// <summary>
        /// comment
        /// </summary>
        private const string COMMENT = "comment";

        /// <summary>
        /// corruptEver
        /// </summary>
        private const string CORRUPT_EVER = "corruptEver";

        /// <summary>
        /// creator
        /// </summary>
        private const string CREATOR = "creator";

        /// <summary>
        /// dateCreated
        /// </summary>
        private const string DATE_CREATED = "dateCreated";

        /// <summary>
        /// desiredAvailable
        /// </summary>
        private const string DESIRED_AVAILABLE = "desiredAvailable";

        /// <summary>
        /// doneDate
        /// </summary>
        private const string DONE_DATE = "doneDate";

        /// <summary>
        /// downloadDir
        /// </summary>
        private const string DOWNLOAD_DIR = "downloadDir";

        /// <summary>
        /// downloadedEver
        /// </summary>
        private const string DOWNLOADED_EVER = "downloadedEver";

        /// <summary>
        /// downloadLimit
        /// </summary>
        private const string DOWNLOAD_LIMIT = "downloadLimit";

        /// <summary>
        /// downloadLimited
        /// </summary>
        private const string DOWNLOAD_LIMITED = "downloadLimited";

        /// <summary>
        /// error
        /// </summary>
        private const string ERROR = "error";

        /// <summary>
        /// errorString
        /// </summary>
        private const string ERROR_STRING = "errorString";

        /// <summary>
        /// eta
        /// </summary>
        private const string ETA = "eta";

        /// <summary>
        /// etaIdle
        /// </summary>
        private const string ETA_IDLE = "etaIdle";

        /// <summary>
        /// files
        /// </summary>
        private const string FILES = "files";

        /// <summary>
        /// fileStats
        /// </summary>
        private const string FILE_STATS = "fileStats";

        /// <summary>
        /// hashString
        /// </summary>
        private const string HASH_STRING = "hashString";

        /// <summary>
        /// haveUnchecked
        /// </summary>
        private const string HAVE_UNCHECKED = "haveUnchecked";

        /// <summary>
        /// haveValid
        /// </summary>
        private const string HAVE_VALID = "haveValid";

        /// <summary>
        /// honorsSessionLimits
        /// </summary>
        private const string HONORS_SESSION_LIMITS = "honorsSessionLimits";

        /// <summary>
        /// id
        /// </summary>
        private const string ID = "id";

        /// <summary>
        /// isFinished
        /// </summary>
        private const string IS_FINISHED = "isFinished";

        /// <summary>
        /// isPrivate
        /// </summary>
        private const string IS_PRIVATE = "isPrivate";

        /// <summary>
        /// isStalled
        /// </summary>
        private const string IS_STALLED = "isStalled";

        /// <summary>
        /// leftUntilDone
        /// </summary>
        private const string LEFT_UNTIL_DONE = "leftUntilDone";

        /// <summary>
        /// magnetLink
        /// </summary>
        private const string MAGNET_LINK = "magnetLink";

        /// <summary>
        /// manualAnnounceTime
        /// </summary>
        private const string MANUAL_ANNOUNCE_TIME = "manualAnnounceTime";

        /// <summary>
        /// maxConnectedPeers
        /// </summary>
        private const string MAX_CONNECTED_PEERS = "maxConnectedPeers";

        /// <summary>
        /// metadataPercentComplete
        /// </summary>
        private const string METADATA_PERCENT_COMPLETE = "metadataPercentComplete";

        /// <summary>
        /// name
        /// </summary>
        private const string NAME = "name";

        /// <summary>
        /// peer-limit
        /// </summary>
        private const string PEER_LIMIT = "peer-limit";

        /// <summary>
        /// peers
        /// </summary>
        private const string PEERS = "peers";

        /// <summary>
        /// peersConnected
        /// </summary>
        private const string PEERS_CONNECTED = "peersConnected";

        /// <summary>
        /// peersFrom
        /// </summary>
        private const string PEERS_FROM = "peersFrom";

        /// <summary>
        /// peersGettingFromUs
        /// </summary>
        private const string PEERS_GETTING_FROM_US = "peersGettingFromUs";

        /// <summary>
        /// peersSendingToUs
        /// </summary>
        private const string PEERS_SENDING_TO_US = "peersSendingToUs";

        /// <summary>
        /// percentDone
        /// </summary>
        private const string PERCENT_DONE = "percentDone";

        /// <summary>
        /// pieces
        /// </summary>
        private const string PIECES = "pieces";

        /// <summary>
        /// pieceCount
        /// </summary>
        private const string PIECE_COUNT = "pieceCount";

        /// <summary>
        /// pieceSize
        /// </summary>
        private const string PIECE_SIZE = "pieceSize";

        /// <summary>
        /// priorities
        /// </summary>
        private const string PRIORITIES = "priorities";

        /// <summary>
        /// queuePosition
        /// </summary>
        private const string QUEUE_POSITION = "queuePosition";

        /// <summary>
        /// rateDownload
        /// </summary>
        private const string RATE_DOWNLOAD = "rateDownload";

        /// <summary>
        /// rateUpload
        /// </summary>
        private const string RATE_UPLOAD = "rateUpload";

        /// <summary>
        /// secondsDownloading
        /// </summary>
        private const string SECONDS_DOWNLOADING = "secondsDownloading";

        /// <summary>
        /// secondsSeeding
        /// </summary>
        private const string SECONDS_SEEDING = "secondsSeeding";

        /// <summary>
        /// seedIdleLimit
        /// </summary>
        private const string SEED_IDLE_LIMIT = "seedIdleLimit";

        /// <summary>
        /// seedIdleMode
        /// </summary>
        private const string SEED_IDLE_MODE = "seedIdleMode";

        /// <summary>
        /// seedRatioLimit
        /// </summary>
        private const string SEED_RATIO_LIMIT = "seedRatioLimit";

        /// <summary>
        /// seedRatioMode
        /// </summary>
        private const string SEED_RATIO_MODE = "seedRatioMode";

        /// <summary>
        /// sizeWhenDone
        /// </summary>
        private const string SIZE_WHEN_DONE = "sizeWhenDone";

        /// <summary>
        /// seedRatioLimit
        /// </summary>
        private const string START_DATE = "startDate";

        /// <summary>
        /// status
        /// </summary>
        private const string STATUS = "status";

        /// <summary>
        /// trackers
        /// </summary>
        private const string TRACKERS = "trackers";

        /// <summary>
        /// seedRatioLimit
        /// </summary>
        private const string TRACKER_STATS = "trackerStats";

        /// <summary>
        /// totalSize
        /// </summary>
        private const string TOTAL_SIZE = "totalSize";

        /// <summary>
        /// torrentFile
        /// </summary>
        private const string TORRENT_FILE = "torrentFile";

        /// <summary>
        /// uploadedEver
        /// </summary>
        private const string UPLOADED_EVER = "uploadedEver";

        /// <summary>
        /// uploadLimit
        /// </summary>
        private const string UPLOAD_LIMIT = "uploadLimit";

        /// <summary>
        /// uploadLimited
        /// </summary>
        private const string UPLOAD_LIMITED = "uploadedEver";

        /// <summary>
        /// uploadRatio
        /// </summary>
        private const string UPLOAD_RATIO = "uploadRatio";

        /// <summary>
        /// wanted
        /// </summary>
        private const string WANTED = "wanted";

        /// <summary>
        /// webseeds
        /// </summary>
        private const string WEB_SEEDS = "webseeds";

        /// <summary>
        /// webseedsSendingToUs
        /// </summary>
        private const string WEB_SEEDS_SENDING_TO_US = "webseedsSendingToUs";

        public static string[] AllFields
        {
            get
            {
                return new[]
                {
                    #region ALL FIELDS
                    ACTIVITY_DATE,
                    ADDED_DATE,
                    BANDWIDTH_PRIORITY,
                    COMMENT,
                    CORRUPT_EVER,
                    CREATOR,
                    DATE_CREATED,
                    DESIRED_AVAILABLE,
                    DONE_DATE,
                    DOWNLOAD_DIR,
                    DOWNLOADED_EVER,
                    DOWNLOAD_LIMIT,
                    DOWNLOAD_LIMITED,
                    ERROR,
                    ERROR_STRING,
                    ETA,
                    ETA_IDLE,
                    FILES,
                    FILE_STATS,
                    HASH_STRING,
                    HAVE_UNCHECKED,
                    HAVE_VALID,
                    HONORS_SESSION_LIMITS,
                    ID,
                    IS_FINISHED,
                    IS_PRIVATE,
                    IS_STALLED  ,
                    LEFT_UNTIL_DONE,
                    MAGNET_LINK,
                    MANUAL_ANNOUNCE_TIME,
                    MAX_CONNECTED_PEERS,
                    METADATA_PERCENT_COMPLETE,
                    NAME,
                    PEER_LIMIT,
                    PEERS,
                    PEERS_CONNECTED,
                    PEERS_FROM,
                    PEERS_GETTING_FROM_US,
                    PEERS_SENDING_TO_US,
                    PERCENT_DONE,
                    PIECES,
                    PIECE_COUNT,
                    PIECE_SIZE,
                    PRIORITIES,
                    QUEUE_POSITION,
                    RATE_DOWNLOAD,
                    RATE_UPLOAD,
                    SECONDS_DOWNLOADING,
                    SECONDS_SEEDING,
                    SEED_IDLE_LIMIT,
                    SEED_IDLE_MODE,
                    SEED_RATIO_LIMIT,
                    SEED_RATIO_MODE,
                    SIZE_WHEN_DONE,
                    START_DATE,
                    STATUS,
                    TRACKERS,
                    TRACKER_STATS,
                    TOTAL_SIZE,
                    TORRENT_FILE,
                    UPLOADED_EVER,
                    UPLOAD_LIMIT,
                    UPLOAD_LIMITED,
                    UPLOAD_RATIO,
                    WANTED,
                    WEB_SEEDS,
                    WEB_SEEDS_SENDING_TO_US,
                    #endregion
                };
            }
        }
    }
}
