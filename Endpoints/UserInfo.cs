using System;

namespace InstaSharp.Endpoints
{
    [Serializable]
    public class UserInfo
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Full_Name { get; set; }
        public string Profile_Picture { get; set; }
    }
}
