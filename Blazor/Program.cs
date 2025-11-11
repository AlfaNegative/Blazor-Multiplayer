// using Blazor.Components;

// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.
// builder.Services.AddRazorComponents()
//     .AddInteractiveServerComponents();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("/Error", createScopeForErrors: true);
//     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//     app.UseHsts();
// }

// app.UseHttpsRedirection();


// app.UseAntiforgery();

// app.MapStaticAssets();
// app.MapRazorComponents<App>()
//     .AddInteractiveServerRenderMode();

// app.Run();

using System.Text.Json;

Game someGame = new Game();
someGame.StartGame();

// get a string version of someGame

await Task.Delay(3000);

string someGameJson = JsonSerializer.Serialize(GameDTO.GameToDTO(someGame));
Console.WriteLine("Writing and reading from FS");
Console.WriteLine(someGameJson);

// File.WriteAllText("game.json", someGameJson);

// File.ReadAllText("game.json");

GameDTO? copyOfGameDTO = JsonSerializer.Deserialize<GameDTO>(someGameJson);
Game? restoredGame = copyOfGameDTO?.ToGame();


// if(copyOfGame == null)
// {
//     // failed to parse
// }


// DTO - Data Tranfer Object