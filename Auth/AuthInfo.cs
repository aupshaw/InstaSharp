using System;
using InstaSharp.Config;
using InstaSharp.Endpoints;

namespace InstaSharp.Auth
{
    [Serializable]
    public class AuthInfo
    {
        public string Access_Token { get; set; }
        public UserInfo User { get; set; }
        public InstagramConfig Config { get; set; }
    }
}
