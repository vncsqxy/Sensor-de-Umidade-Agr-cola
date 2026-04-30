using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using Shared;
using SensorInterface.Commands;

namespace SensorInterface.ViewModels;

public class MainViewModel : BaseViewModel
{
    private readonly HttpClient _httpClient = new() { BaseAddress = new Uri("https://localhost:7123/") };
    public ObservableCollection<SensorData> Historico { get; set; } = new();

    public RelayCommand AtualizarCommand { get; set; }

    public MainViewModel()
    {
        AtualizarCommand = new RelayCommand(_ => CarregarDados());
        CarregarDados(); // Carrega ao abrir
    }

    private async void CarregarDados()
    {
        try
        {
            var dados = await _httpClient.GetFromJsonAsync<List<SensorData>>("api/Sensor");
            if (dados != null)
            {
                Historico.Clear();
                foreach (var item in dados) Historico.Add(item);
            }
        }
        catch { /* Erro de conexão */ }
    }
}