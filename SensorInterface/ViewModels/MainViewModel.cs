using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Input;
using Shared; // Usando o DTO da Shared
using SensorInterface.Commands;

namespace SensorInterface.ViewModels;

public class MainViewModel : BaseViewModel
{
    // Porta 7161 conforme vimos no seu Swagger
    private readonly HttpClient _httpClient = new() { BaseAddress = new Uri("https://localhost:7161/") };

    // Lista que a tela vai "observar"
    public ObservableCollection<SensorData> Historico { get; set; } = new();

    public ICommand AtualizarCommand { get; set; }

    public MainViewModel()
    {
        AtualizarCommand = new RelayCommand(_ => CarregarDados());
        CarregarDados();
    }

    private async void CarregarDados()
    {
        try
        {
            // Busca os DTOs persistidos no banco da API
            var dados = await _httpClient.GetFromJsonAsync<List<SensorData>>("api/Sensor");
            if (dados != null)
            {
                Historico.Clear();
                foreach (var item in dados) Historico.Add(item);
            }
        }
        catch { /* Erro de conexão com a API */ }
    }
}