using System.Collections.Generic;

namespace InstaSharp.Model.Responses
{
    public class CommentsResponse : IResponse
    {
        public string Json { get; set; }

        [JsonMapping("meta", JsonMapping.MappingType.Class)]
        public Model.Meta Meta { get; set; }
        [JsonMapping("data", JsonMapping.MappingType.Collection)]
        public IList<Comments> Data { get; set; }
    }
}
