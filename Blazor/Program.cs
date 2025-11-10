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

Game someGame = new();

// get a string version of someGame

string someGameJson = JsonSerializer.Serialize(someGame);
Console.WriteLine(someGameJson);

// File.WriteAllText("game.json", someGameJson);

// File.ReadAllText("game.json");

Game? copyOfGame = JsonSerializer.Deserialize<Game>(someGameJson);
Console.WriteLine(copyOfGame);
// if(copyOfGame == null)
// {
//     // failed to parse
// }