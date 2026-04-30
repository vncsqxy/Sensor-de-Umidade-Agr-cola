using System.Net.Http.Json;
using Shared;

Console.WriteLine("======= SIMULADOR DE SENSOR DE UMIDADE =======");

// IMPORTANTE: Confira no seu navegador o número da porta. 
// Na sua imagem era 7161. Se mudar, ajuste o número abaixo:
var apiUrl = "https://localhost:7161/api/Sensor";

using var client = new HttpClient();
Random rnd = new Random();

while (true)
{
    // Gera um valor aleatório de umidade entre 10% e 90%
    double umidadeLida = Math.Round(rnd.NextDouble() * (90 - 10) + 10, 2);

    var novaLeitura = new SensorData
    {
        SensorNome = "Sensor_Talhao_Sul_01",
        ValorUmidade = umidadeLida
    };

    try
    {
        var response = await client.PostAsJsonAsync(apiUrl, novaLeitura);

        if (response.IsSuccessStatusCode)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Enviado: {umidadeLida}% - Status: OK");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Erro na API: {response.StatusCode}");
        }
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Erro de conexão: Verifique se a API está rodando.");
    }

    Console.ResetColor();
    // Espera 5 segundos para enviar a próxima leitura
    await Task.Delay(5000);
}