using System.Text.Json.Serialization;

namespace ApiAlegra.Dto.Request
{
    public class ConsultarCustomFieldRequest
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("key")]
        public string? Key { get; set; }

        [JsonPropertyName("defaultValue")]
        public string? DefaultValue { get; set; }

        [JsonPropertyName("settings")]
        public CustomFieldSettings? Settings { get; set; }
    }

    public class CustomFieldSettings
    {
        [JsonPropertyName("isRequired")]
        public bool IsRequired { get; set; }

        [JsonPropertyName("printOnInvoices")]
        public bool PrintOnInvoices { get; set; }
    }
}
