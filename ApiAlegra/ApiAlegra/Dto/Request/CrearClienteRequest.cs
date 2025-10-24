using System.Text.Json.Serialization;

namespace ApiAlegra.Dto.Request
{
    public class CrearClienteRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("identification")]
        public string Identification { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("phonePrimary")]
        public string PhonePrimary { get; set; }

        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("fiscalResidence")]
        public string FiscalResidence { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("kindOfPerson")]
        public string KindOfPerson { get; set; }

        [JsonPropertyName("regime")]
        public string Regime { get; set; }

        [JsonPropertyName("nameObject")]
        public NameObject NameObject { get; set; }

        [JsonPropertyName("identificationObject")]
        public IdentificationObject IdentificationObject { get; set; }

        [JsonPropertyName("address")]
        public Address Address { get; set; }

        [JsonPropertyName("settings")]
        public Settings Settings { get; set; }

        [JsonPropertyName("statementAttached")]
        public bool StatementAttached { get; set; }

    }


    public class NameObject
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("secondName")]
        public string? SecondName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("secondLastName")]
        public string? SecondLastName { get; set; }
    }

    public class IdentificationObject
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("dv")]
        public int? Dv { get; set; }
    }

    public class Address
    {
        [JsonPropertyName("address")]
        public string AddressLine { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("department")]
        public string Department { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("zipCode")]
        public string? ZipCode { get; set; }
    }

    public class Settings
    {
        [JsonPropertyName("sendElectronicDocuments")]
        public bool SendElectronicDocuments { get; set; }
    }
}
