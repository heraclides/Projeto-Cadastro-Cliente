using Microsoft.AspNetCore.SignalR;

namespace LHPet.Models;

public class Cliente
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public string? Email { get; set; }
    public string? Paciente { get; set; }

   
}