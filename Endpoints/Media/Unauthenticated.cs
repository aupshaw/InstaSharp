﻿using System;
using InstaSharp.Config;
using InstaSharp.Model.Responses;

namespace InstaSharp.Endpoints.Media
{
    public class Unauthenticated : InstagramAPI
    {
        public Unauthenticated(InstagramConfig config) : base(config, "/media/") {}

        public MediaResponse Get(string mediaId)
        {
            return (MediaResponse)Mapper.Map<MediaResponse>(GetJson(mediaId));
        }

        public string GetJson(string mediaId)
        {
            string uri = string.Format(base.Uri + "{0}?client_id={1}", mediaId, InstagramConfig.ClientId);
            return HttpClient.GET(uri);
        }

        public MediasResponse Popular()
        {
            return (MediasResponse)Mapper.Map<MediasResponse>(PopularJson());
        }

        public string PopularJson()
        {
            string uri = string.Format(base.Uri + "popular/?client_id={0}", InstagramConfig.ClientId);
            return HttpClient.GET(uri);
        }

        public MediasResponse Search(double latitude, double longitude)
        {
            return Search(latitude, longitude, null, null, 0);
        }

        public MediasResponse Search(double latitude, double longitude, DateTime? maxTimestamp, DateTime? minTimestamp)
        {
            return Search(latitude, longitude, maxTimestamp, minTimestamp, 0);
        }

        public MediasResponse Search(double latitude, double longitude, DateTime? maxTimestamp, DateTime? minTimestamp, int distance)
        {
            return (MediasResponse)Mapper.Map<MediasResponse>(SearchJson(latitude, longitude, maxTimestamp, minTimestamp, distance));
        }

        private string SearchJson(double latitude, double longitude, DateTime? maxTimestamp, DateTime? minTimestamp, int distance)
        {
            string uri = string.Format(base.Uri + "search?client_id={0}&lat={1}&lng={2}", InstagramConfig.ClientId, latitude, longitude);

            if (maxTimestamp != null) uri += string.Format("&max_timestamp={0}&min_timestamp={1}", maxTimestamp, minTimestamp);
            if (distance != 0) uri += "&distance=" + distance;

            return HttpClient.GET(uri);
        }
    }
}
