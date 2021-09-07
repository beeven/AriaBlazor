using System;
using System.Collections.Generic;

namespace AriaBlazor.Models
{
    public record AriaTaskStatus
    {
        public string GID {get;set;} = "";
        public TaskStatus Status {get;set;}
        public int TotalLength {get;set;}
        public int CompletedLength {get;set;}
        public int UploadLength {get;set;}
        public string? BitField {get;set;}
        public int DownloadSpeed {get;set;}
        public int UploadSpeed {get;set;}
        public string? InfoHash {get;set;}
        public int? NumSeeers {get;set;}
        public bool? Seeder {get;set;}
        public int PieceLength {get;set;}
        public int NumPieces {get;set;}
        public int Connections {get;set;}
        public string? ErrorCode {get;set;}
        public string? ErrorMessage {get;set;}
        public string[]? FollowedBy {get;set;}
        public string[]? Following {get;set;}
        public string[]? BelongsTo {get;set;}
        public string? Dir {get;set;}
        public FileInfo[]? Files {get;set;}

    }

    public enum TaskStatus
    {
        Active,
        Waiting,
        Paused,
        Error,
        Complete,
        Removed
    }

    public record FileInfo 
    {
        public int Index {get;set;}
        public string Path {get;set;} = "";
        public int Length {get;set;}
        public int CompletedLength {get;set;}
        public bool Selected {get;set;}
        public UriInfo[] Uris {get;set;} = {};
        public BitTorrentInfo? BitTorrent {get;set;}
        public int? VerifiedLength {get;set;}
        public bool? VerifyIntegrityPending {get;set;}
    }

    public record UriInfo
    {
        public string Uri {get;set;} = "";
        public UriStatus Status {get;set;}
    }

    public enum UriStatus
    {
        Used,
        Waiting,
    }

    public record BitTorrentInfo
    {
        public string[] AnnounceList {get;set;} = {};
        public string Comment {get;set;} = "";
        public DateTimeOffset CreationDate {get;set;}
        public BitTorrentMode Mode {get;set;}
        public Dictionary<string,string>? Info {get;set;}

    }

    public enum BitTorrentMode
    {
        Single,
        Multi
    }
}