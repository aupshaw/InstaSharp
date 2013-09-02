namespace InstaSharp.Model.Responses
{
    public class CommentResponse : IResponse
    {
        public string Json { get; set; }

        [JsonMapping("meta", JsonMapping.MappingType.Class)]
        public Meta Meta { get; set; }
        [JsonMapping("data", JsonMapping.MappingType.Primitive)]
        public string Data { get; set; }
    }
}
