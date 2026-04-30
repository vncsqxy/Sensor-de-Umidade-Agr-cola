namespace Shared;

public class SensorData
{
    public int Id { get; set; }
    public string SensorNome { get; set; } = string.Empty;
    public double ValorUmidade { get; set; }
    public DateTime DataLeitura { get; set; }
    public string Status { get; set; } = string.Empty;
}