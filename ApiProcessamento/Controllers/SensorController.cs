using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiProcessamento.Data;
using Shared; // ADICIONEI ESTA LINHA - Sem ela o SensorData não é encontrado

namespace ApiProcessamento.Controllers;

[ApiController]
[Route("api/[controller]")]
// Utilizando Construtor Primário para sumir com o aviso do VS 2022
public class SensorController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

    // GET: api/sensor (Busca todos os dados para mostrar na tela WPF)
    [HttpGet]
    public async Task<ActionResult<IEnumerable<SensorData>>> Get()
    {
        // Retorna a lista de leituras do banco
        return await _context.LeiturasUmidade.OrderByDescending(x => x.Id).ToListAsync();
    }

    // POST: api/sensor (O simulador envia os dados para cá)
    [HttpPost]
    public async Task<ActionResult<SensorData>> Post(SensorData dto)
    {
        dto.DataLeitura = DateTime.Now;

        // Lógica de monitoramento agrícola (Requisito da SA)
        if (dto.ValorUmidade < 30)
            dto.Status = "Solo Seco: Ativar Irrigação";
        else if (dto.ValorUmidade > 70)
            dto.Status = "Solo Encharcado: Risco de Fungos";
        else
            dto.Status = "Umidade Ideal";

        _context.LeiturasUmidade.Add(dto);
        await _context.SaveChangesAsync();

        return Ok(dto);
    }
}