using System.Text.Json.Serialization;

namespace ApiAlegra.Dto.Request
{
    public class CrearEmpresaRequest
    {
        [JsonPropertyName("identificationObject")]
        public IdentificationObjects IdentificationObject { get; set; }

        [JsonPropertyName("kindOfPerson")]
        public string KindOfPerson { get; set; } = string.Empty;

        [JsonPropertyName("regime")]
        public string Regime { get; set; } = string.Empty;

        [JsonPropertyName("address")]
        public Addresss Address { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("fiscalResidence")]
        public string FiscalResidence { get; set; } = string.Empty;

        [JsonPropertyName("enableHealthSector")]
        public bool EnableHealthSector { get; set; }

        [JsonPropertyName("phonePrimary")]
        public string PhonePrimary { get; set; } = string.Empty;

        [JsonPropertyName("mobile")]
        public string Mobile { get; set; } = string.Empty;

        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        [JsonPropertyName("statementAttached")]
        public string StatementAttached { get; set; } = string.Empty;
    }

    public class IdentificationObjects
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("number")]
        public string Number { get; set; } = string.Empty;

        [JsonPropertyName("dv")]
        public string Dv { get; set; } = string.Empty;
    }

    public class Addresss
    {
        [JsonPropertyName("city")]
        public string City { get; set; } = string.Empty;

        [JsonPropertyName("department")]
        public string Department { get; set; } = string.Empty;

        [JsonPropertyName("address")]
        public string AddressDetail { get; set; } = string.Empty;

        [JsonPropertyName("country")]
        public string Country { get; set; } = string.Empty;
    }
}
