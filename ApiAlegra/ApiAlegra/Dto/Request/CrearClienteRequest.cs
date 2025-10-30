using System.Text.Json.Serialization;

namespace ApiAlegra.Dto.Request
{
    public class CrearClienteRequest
    {
        [JsonPropertyName("nameObject")]
        public NameObject? NameObject { get; set; }

        [JsonPropertyName("identificationObject")]
        public IdentificationObject? IdentificationObject { get; set; }

        [JsonPropertyName("kindOfPerson")]
        public string? KindOfPerson { get; set; }

        [JsonPropertyName("regime")]
        public string? Regime { get; set; }

        [JsonPropertyName("address")]
        public Address? Address { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("fiscalResidence")]
        public string? FiscalResidence { get; set; }

        [JsonPropertyName("enableHealthSector")]
        public bool EnableHealthSector { get; set; }

        [JsonPropertyName("phonePrimary")]
        public string? PhonePrimary { get; set; }

        [JsonPropertyName("mobile")]
        public string? Mobile { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("statementAttached")]
        public string? StatementAttached { get; set; }
    }

    public class NameObject
    {
        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        [JsonPropertyName("secondName")]
        public string? SecondName { get; set; }

        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }
    }

    public class IdentificationObject
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("number")]
        public string? Number { get; set; }
    }

    public class Address
    {
        [JsonPropertyName("city")]
        public string? City { get; set; }

        [JsonPropertyName("department")]
        public string? Department { get; set; }

        [JsonPropertyName("address")]
        public string? AddressDetail { get; set; }

        [JsonPropertyName("country")]
        public string? Country { get; set; }
    }
}
