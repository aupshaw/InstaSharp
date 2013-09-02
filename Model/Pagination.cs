namespace InstaSharp.Model
{
    public class Pagination
    {
        [JsonMapping("next_url", JsonMapping.MappingType.Primitive)]
        public string NextUrl { get; set; }
        
        [JsonMapping("next_max_id", JsonMapping.MappingType.Primitive)]
        public string NextMaxId { get; set; }

        [JsonMapping("next_min_id", JsonMapping.MappingType.Primitive)]
        public string NextMinId { get; set; }

        [JsonMapping("min_tag_id", JsonMapping.MappingType.Primitive)]
        public string MinTagId { get; set; }
    }
}
