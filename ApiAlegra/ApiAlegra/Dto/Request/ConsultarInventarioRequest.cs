using System.Text.Json.Serialization;

namespace ApiAlegra.Dto.Request
{
    public class ConsultarInventarioRequest
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("category")]
        public Category? Category { get; set; }

        [JsonPropertyName("hasNoIvaDays")]
        public bool HasNoIvaDays { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("reference")]
        public string? Reference { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("calculationScale")]
        public int CalculationScale { get; set; }

        [JsonPropertyName("price")]
        public List<Price>? Price { get; set; }

        [JsonPropertyName("inventory")]
        public Inventory? Inventory { get; set; }

        [JsonPropertyName("tax")]
        public List<Tax>? Tax { get; set; }

        [JsonPropertyName("customFields")]
        public List<CustomField>? CustomFields { get; set; }

        [JsonPropertyName("productKey")]
        public string? ProductKey { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("itemType")]
        public string? ItemType { get; set; }
    }

    public class Category
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    public class Price
    {
        [JsonPropertyName("idPriceList")]
        public string? IdPriceList { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("price")]
        public decimal PriceValue { get; set; }

        [JsonPropertyName("currency")]
        public Currency? Currency { get; set; }

        [JsonPropertyName("main")]
        public bool Main { get; set; }

        [JsonPropertyName("edited")]
        public bool Edited { get; set; }
    }

    public class Currency
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }
    }

    public class Inventory
    {
        [JsonPropertyName("unit")]
        public string? Unit { get; set; }
    }

    public class Tax
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("percentage")]
        public string? Percentage { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("deductible")]
        public string? Deductible { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("categoryFavorable")]
        public TaxCategorys? CategoryFavorable { get; set; }

        [JsonPropertyName("categoryToBePaid")]
        public TaxCategorys? CategoryToBePaid { get; set; }

        [JsonPropertyName("rate")]
        public string? Rate { get; set; }
    }

    public class TaxCategorys
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

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

        [JsonPropertyName("readOnly")]
        public bool ReadOnly { get; set; }

        [JsonPropertyName("nature")]
        public string? Nature { get; set; }

        [JsonPropertyName("blocked")]
        public string? Blocked { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("categoryRule")]
        public CategoryRules? CategoryRule { get; set; }

        [JsonPropertyName("use")]
        public string? Use { get; set; }

        [JsonPropertyName("showThirdPartyBalance")]
        public bool ShowThirdPartyBalance { get; set; }
    }

    public class CategoryRules
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("key")]
        public string? Key { get; set; }
    }

    public class CustomField
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("label")]
        public string? Label { get; set; }

        [JsonPropertyName("key")]
        public string? Key { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("isRequired")]
        public bool IsRequired { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }
}
