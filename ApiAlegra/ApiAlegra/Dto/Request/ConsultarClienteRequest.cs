using System.Net;
using System.Text.Json.Serialization;

namespace ApiAlegra.Dto.Request
{
    public class ConsultarClienteRequest
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("identification")]
        public string? Identification { get; set; }

        [JsonPropertyName("phonePrimary")]
        public string? PhonePrimary { get; set; }

        [JsonPropertyName("phoneSecondary")]
        public string? PhoneSecondary { get; set; }

        [JsonPropertyName("mobile")]
        public string? Mobile { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("emailSecondary")]
        public string? EmailSecondary { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("type")]
        public List<string>? Type { get; set; }

        [JsonPropertyName("address")]
        public Address? Address { get; set; }

        [JsonPropertyName("term")]
        public object? Term { get; set; }

        [JsonPropertyName("seller")]
        public object? Seller { get; set; }

        [JsonPropertyName("priceList")]
        public object? PriceList { get; set; }

        [JsonPropertyName("statementAttached")]
        public bool? StatementAttached { get; set; }

        [JsonPropertyName("fax")]
        public string? Fax { get; set; }

        [JsonPropertyName("observations")]
        public string? Observations { get; set; }

        [JsonPropertyName("accounting")]
        public Accounting? Accounting { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("branchOffices")]
        public List<object>? BranchOffices { get; set; }

        [JsonPropertyName("attachmentsTotal")]
        public int? AttachmentsTotal { get; set; }

        [JsonPropertyName("creditLimit")]
        public object? CreditLimit { get; set; }

        [JsonPropertyName("identificationObject")]
        public IdentificationObject? IdentificationObject { get; set; }

        [JsonPropertyName("kindOfPerson")]
        public string? KindOfPerson { get; set; }

        [JsonPropertyName("regime")]
        public string? Regime { get; set; }

        [JsonPropertyName("fiscalResponsabilities")]
        public List<object>? FiscalResponsabilities { get; set; }

        [JsonPropertyName("enableHealthSector")]
        public bool? EnableHealthSector { get; set; }

        [JsonPropertyName("healthPatients")]
        public object? HealthPatients { get; set; }

        [JsonPropertyName("fiscalResidence")]
        public string? FiscalResidence { get; set; }

        [JsonPropertyName("nameObject")]
        public NameObject? NameObject { get; set; }
    }


    public class Accounting
    {
        [JsonPropertyName("accountReceivable")]
        public AccountDetail? AccountReceivable { get; set; }

        [JsonPropertyName("debtToPay")]
        public AccountDetail? DebtToPay { get; set; }
    }

    public class AccountDetail
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("idGlobal")]
        public string? IdGlobal { get; set; }

        [JsonPropertyName("idParent")]
        public string? IdParent { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("text")]
        public string? Text { get; set; }

        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("nature")]
        public string? Nature { get; set; }

        [JsonPropertyName("blocked")]
        public string? Blocked { get; set; }

        [JsonPropertyName("readOnly")]
        public object? ReadOnly { get; set; } // Puede ser bool o string

        [JsonPropertyName("use")]
        public string? Use { get; set; }

        [JsonPropertyName("showThirdPartyBalance")]
        public bool? ShowThirdPartyBalance { get; set; }

        [JsonPropertyName("parameterizedMovement")]
        public bool? ParameterizedMovement { get; set; }

        [JsonPropertyName("behavior")]
        public string? Behavior { get; set; }

        [JsonPropertyName("categoryRule")]
        public CategoryRule? CategoryRule { get; set; }

        [JsonPropertyName("children")]
        public List<object>? Children { get; set; }
    }

    public class CategoryRule
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("key")]
        public string? Key { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
