using System.Net.Sockets;
using System.Text;

namespace ApiAlegra.Service
{
    public class CustomFieldService
    {
        private readonly HttpClient _httpClient;
        public CustomFieldService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<(bool Success, string? Content, string? ErrorMessage)>
            ConsultarCustomFields(string usuario, string token)
        {
            var authString = $"{usuario}:{token}";
            var authBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(authString));
            Console.WriteLine($"Auth original: {authString}");
            Console.WriteLine("Auth codificado en Base64: " + authBase64);
            var url = "https://api.alegra.com/api/v1/custom-fields";
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {authBase64}");
            try
            {
                var response = await _httpClient.GetAsync(url);
                var responseContent = await response.Content.ReadAsStringAsync();

                return (response.IsSuccessStatusCode, responseContent, null);
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

    }
}
