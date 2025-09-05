using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "Hello World!");
public class LoginDTO
{
    public required string Email { get; set; }
    public required string Password { get; set; }
}

app.MapPost("/login", (LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "admTeste.com" && loginDTO.Password == "123456")
        return Results.Ok("Login com sucesso");
    else
        return Results.Unauthorized();
});

app.Run();
public class loginDTO 
    {
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
// Removed duplicate loginDTO class definition