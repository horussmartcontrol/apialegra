using System.Text.Json.Serialization;

namespace ApiAlegra.Dto.Request
{
    public class CrearItemsRequest
    {
        [JsonPropertyName("customFields")]
        public List<CustomFields>? CustomFields { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("tax")]
        public string? Tax { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class CustomFields
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }
}
