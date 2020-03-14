namespace PlexBuilder
{
    public class plexserverapi
    {
        public string BaseUrl { get; set; }
        public string Token { get; set; }
        public string TokenKey => "X-Plex-Token";
        public string PContainerStartKey => "X-Plex-Container-Start";
        public string ContainerSizeKey => "X-Plex-Container-Size";
        public string SortKey => "sort";
        public string SortDateAddedDescValue => "addedAt:desc";
        public string SortDateAddedAscValue => "addedAt:asc";
    }
}
