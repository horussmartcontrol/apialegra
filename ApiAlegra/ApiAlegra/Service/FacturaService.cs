using ApiAlegra.Dto.Request;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace ApiAlegra.Service
{
    public class FacturaService
    {
        private readonly HttpClient _httpClient;
        public FacturaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<(bool Success, string? Content, string? ErrorMessage)>
            CrearFactura(string usuario, string token, CrearFacturaRequest facturaRequest)
        {
            var authString = $"{usuario}:{token}";
            var authBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(authString));

            Console.WriteLine("Auth original: " + authString);
            Console.WriteLine("Auth codificado en Base64: " + authBase64);

            var url = "https://api.alegra.com/api/v1/invoices";
            var jsonBody = JsonSerializer.Serialize(facturaRequest);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {authBase64}");

            try
            {
                var response = await _httpClient.PostAsync(url, content);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return (true, responseContent, null);
                }
                else
                {
                    return (false, responseContent, null);
                }

            }
            catch (HttpRequestException ex) when (ex.InnerException is SocketException)
            {
                return (false, null, $"No tienes conexión a internet o no se pudo resolver el host. {ex.Message}");
            }
            catch (HttpRequestException ex)
            {
                return (false, null, $"Error HTTP: {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, null, $"Error inesperado: {ex.Message}");
            }

        }

        public async Task<(bool Success, string Content, string? ErrorMessage)>
            ConsultarFactura(
            string usuario,
            string token
            )
        {
            var content = string.Empty;
            var authString = $"{usuario}:{token}";
            var authBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(authString));

            Console.WriteLine("Auth original: " + authString);
            Console.WriteLine("Auth codificado en Base64: " + authBase64);

            var url = "https://api.alegra.com/api/v1/invoices";



            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {authBase64}");
            try
            {
                var response = await _httpClient.GetAsync(url);
                var responseContent = response.Content;
                if (response.IsSuccessStatusCode)
                {
                    content = await responseContent.ReadAsStringAsync();
                    return (true, content, null);
                }
                else
                {
                    content = await responseContent.ReadAsStringAsync();
                    return (false, content, null);
                }
            }
            catch (HttpRequestException ex) when (ex.InnerException is SocketException)
            {
                return (false, content, $"No tienes conexión a internet o no se pudo resolver el host. {ex.Message}");
            }
            catch (HttpRequestException ex)
            {
                return (false, content, $"Error HTTP: {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, content, $"Error inesperado: {ex.Message}");
            }


        }

        public async Task<(bool Success, string Content, string? ErrorMessage)>
            ConsultarFacturaFecha(
            string usuario,
            string token,
            string fecha
            )
        {

            var content = string.Empty;
            var authString = $"{usuario}:{token}";
            var authBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(authString));

            Console.WriteLine("Auth original: " + authString);
            Console.WriteLine("Auth codificado en Base64: " + authBase64);

            var url = $"https://api.alegra.com/api/v1/invoices?date={fecha}";



            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {authBase64}");
            try
            {
                var response = await _httpClient.GetAsync(url);
                var responseContent = response.Content;


                if (response.IsSuccessStatusCode)
                {
                    content = await responseContent.ReadAsStringAsync();


                    return (true, content, null);
                }
                else
                {
                    content = await responseContent.ReadAsStringAsync();
                    return (false, content, null);
                }
            }
            catch (HttpRequestException ex) when (ex.InnerException is SocketException)
            {
                return (false, content, $"No tienes conexión a internet o no se pudo resolver el host. {ex.Message}");
            }
            catch (HttpRequestException ex)
            {
                return (false, content, $"Error HTTP: {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, content, $"Error inesperado: {ex.Message}");
            }


        }


    }
}
