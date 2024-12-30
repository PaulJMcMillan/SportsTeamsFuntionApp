using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SportsTeamsFuntionApp.Abstractions;
using SportsTeamsFuntionApp.Common;
using SportsTeamsFuntionApp.Services;

var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();

builder.Services.AddSingleton<IMylogger, MyLogger>();
builder.Services.AddTransient<ContextService>();
builder.Services.AddScoped<ISportsTeamsRepositoryService, SportsTeamsRepositoryService>();
builder.Services.AddScoped<ISportsTeamsService, SportsTeamsService>();
builder.Build().Run();
