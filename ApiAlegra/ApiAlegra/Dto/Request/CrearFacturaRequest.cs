using System.Text.Json.Serialization;

namespace ApiAlegra.Dto.Request
{
    public class CrearFacturaRequest
    {
        [JsonPropertyName("client")]
        public ClienteFactura? Client { get; set; }

        [JsonPropertyName("stamp")]
        public Stamp? Stamp { get; set; }

        [JsonPropertyName("paymentMethod")]
        public string? PaymentMethod { get; set; }

        [JsonPropertyName("paymentForm")]
        public string? PaymentForm { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("items")]
        public List<ItemFactura>? Items { get; set; }

        [JsonPropertyName("dueDate")]
        public string? DueDate { get; set; }

        [JsonPropertyName("date")]
        public string? Date { get; set; }

        [JsonPropertyName("payments")]
        public List<PagoFactura>? Payments { get; set; }

        [JsonPropertyName("operationType")]
        public string? OperationType { get; set; }

        [JsonPropertyName("numberDeliveryOrder")]
        public string? NumberDeliveryOrder { get; set; }
    }

    public class ClienteFactura
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }

    public class Stamp
    {
        [JsonPropertyName("generateStamp")]
        public bool GenerateStamp { get; set; }
    }

    public class ItemFactura
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("tax")]
        public List<TaxFactura>? Tax { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
    }

    public class TaxFactura
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }

    public class PagoFactura
    {
        [JsonPropertyName("account")]
        public CuentaPago? Account { get; set; }

        [JsonPropertyName("date")]
        public string? Date { get; set; }

        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        [JsonPropertyName("paymentMethod")]
        public string? PaymentMethod { get; set; }
    }

    public class CuentaPago
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }
}
