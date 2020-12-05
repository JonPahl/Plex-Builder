using PlexBuilder.Concrete;
using PlexBuilder.Models;
using System;

namespace PlexBuilder
{
    public sealed class PlexConfig
    {
        public static Uri BaseUrl { get; set; }
        public static string Token { get; set; }
        public static string TokenKey => "X-Plex-Token";
        public static string PContainerStartKey => "X-Plex-Container-Start";
        public static string ContainerSizeKey => "X-Plex-Container-Size";
        public static string SortKey => "sort";
        public static string SortDateAddedDescValue => "addedAt:desc";
        public static string SortDateAddedAscValue => "addedAt:asc";

        public static void SetupConfig(AppSettings setting)
        {
            var login = new PlexLogin(setting);
            var token = login.Login().Result;

            BaseUrl = new Uri(setting.PlexServer);
            Token = token;
        }
    }
}