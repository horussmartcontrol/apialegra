using System.Text.Json.Serialization;

namespace ApiAlegra.Dto.Request
{
    public class ConsultarFacturaRequest
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("date")]
        public string? Date { get; set; }

        [JsonPropertyName("dueDate")]
        public string? DueDate { get; set; }

        [JsonPropertyName("datetime")]
        public string? DateTime { get; set; }

        [JsonPropertyName("observations")]
        public string? Observations { get; set; }

        [JsonPropertyName("anotation")]
        public string? Anotation { get; set; }

        [JsonPropertyName("termsConditions")]
        public string? TermsConditions { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("client")]
        public InvoiceClient? Client { get; set; }

        [JsonPropertyName("numberTemplate")]
        public NumberTemplate? NumberTemplate { get; set; }

        [JsonPropertyName("subtotal")]
        public decimal? Subtotal { get; set; }

        [JsonPropertyName("discount")]
        public decimal? Discount { get; set; }

        [JsonPropertyName("tax")]
        public decimal? Tax { get; set; }

        [JsonPropertyName("total")]
        public decimal? Total { get; set; }

        [JsonPropertyName("totalPaid")]
        public decimal? TotalPaid { get; set; }

        [JsonPropertyName("balance")]
        public decimal? Balance { get; set; }

        [JsonPropertyName("decimalPrecision")]
        public string? DecimalPrecision { get; set; }

        [JsonPropertyName("warehouse")]
        public Warehouse? Warehouse { get; set; }

        [JsonPropertyName("term")]
        public string? Term { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("paymentForm")]
        public string? PaymentForm { get; set; }

        [JsonPropertyName("paymentMethod")]
        public string? PaymentMethod { get; set; }

        [JsonPropertyName("barCodeContent")]
        public string? BarCodeContent { get; set; }

        [JsonPropertyName("seller")]
        public object? Seller { get; set; }

        [JsonPropertyName("priceList")]
        public object? PriceList { get; set; }

        [JsonPropertyName("payments")]
        public List<Payment>? Payments { get; set; }

        [JsonPropertyName("items")]
        public List<InvoiceItem>? Items { get; set; }

        [JsonPropertyName("costCenter")]
        public object? CostCenter { get; set; }

        [JsonPropertyName("printingTemplate")]
        public PrintingTemplate? PrintingTemplate { get; set; }
    }

    // 📦 CLIENTE
    public class InvoiceClient
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("identification")]
        public string? Identification { get; set; }

        [JsonPropertyName("phonePrimary")]
        public string? PhonePrimary { get; set; }

        [JsonPropertyName("phoneSecondary")]
        public string? PhoneSecondary { get; set; }

        [JsonPropertyName("fax")]
        public string? Fax { get; set; }

        [JsonPropertyName("mobile")]
        public string? Mobile { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("regime")]
        public string? Regime { get; set; }

        [JsonPropertyName("identificationType")]
        public string? IdentificationType { get; set; }

        [JsonPropertyName("address")]
        public ClientAddress? Address { get; set; }

        [JsonPropertyName("kindOfPerson")]
        public string? KindOfPerson { get; set; }

        [JsonPropertyName("identificationObject")]
        public IdentificationObject? IdentificationObject { get; set; }
    }

    public class ClientAddress
    {
        [JsonPropertyName("address")]
        public string? Address { get; set; }

        [JsonPropertyName("department")]
        public string? Department { get; set; }

        [JsonPropertyName("city")]
        public string? City { get; set; }
    }



    // 📜 DETALLES DE FACTURA
    public class NumberTemplate
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        [JsonPropertyName("number")]
        public string? Number { get; set; }

        [JsonPropertyName("text")]
        public string? Text { get; set; }

        [JsonPropertyName("documentType")]
        public string? DocumentType { get; set; }

        [JsonPropertyName("fullNumber")]
        public string? FullNumber { get; set; }

        [JsonPropertyName("formattedNumber")]
        public string? FormattedNumber { get; set; }
    }

    public class Warehouse
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    // 💵 PAGOS
    public class Payment
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        [JsonPropertyName("number")]
        public string? Number { get; set; }

        [JsonPropertyName("date")]
        public string? Date { get; set; }

        [JsonPropertyName("amount")]
        public decimal? Amount { get; set; }

        [JsonPropertyName("paymentMethod")]
        public string? PaymentMethod { get; set; }

        [JsonPropertyName("observations")]
        public string? Observations { get; set; }

        [JsonPropertyName("anotation")]
        public string? Anotation { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }

    // 🧾 ITEMS
    public class InvoiceItem
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("price")]
        public decimal? Price { get; set; }

        [JsonPropertyName("discount")]
        public decimal? Discount { get; set; }

        [JsonPropertyName("reference")]
        public string? Reference { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("productKey")]
        public string? ProductKey { get; set; }

        [JsonPropertyName("unit")]
        public string? Unit { get; set; }

        [JsonPropertyName("tax")]
        public List<TaxInfo>? Tax { get; set; }

        [JsonPropertyName("total")]
        public decimal? Total { get; set; }
    }

    // 💰 IMPUESTOS
    public class TaxInfo
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
        public TaxCategory? CategoryFavorable { get; set; }

        [JsonPropertyName("categoryToBePaid")]
        public TaxCategory? CategoryToBePaid { get; set; }

        [JsonPropertyName("rate")]
        public string? Rate { get; set; }

        [JsonPropertyName("amount")]
        public decimal? Amount { get; set; }
    }

    public class TaxCategory
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
        public bool? ReadOnly { get; set; }

        [JsonPropertyName("nature")]
        public string? Nature { get; set; }

        [JsonPropertyName("blocked")]
        public string? Blocked { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("categoryRule")]
        public CategoryRule? CategoryRule { get; set; }

        [JsonPropertyName("use")]
        public string? Use { get; set; }

        [JsonPropertyName("showThirdPartyBalance")]
        public bool? ShowThirdPartyBalance { get; set; }
    }


    // 🧾 PLANTILLA DE IMPRESIÓN
    public class PrintingTemplate
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("pageSize")]
        public string? PageSize { get; set; }

        [JsonPropertyName("supportedPdfEngine")]
        public string? SupportedPdfEngine { get; set; }
    }
}
