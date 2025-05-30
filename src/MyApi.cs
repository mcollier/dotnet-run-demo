#:sdk Microsoft.NET.Sdk.Web

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

string[] bigTenTeams = new[]
{
    "Illinois",
    "Indiana",
    "Iowa",
    "Maryland",
    "Michigan",
    "Michigan State",
    "Minnesota",
    "Nebraska",
    "Northwestern",
    "Ohio State",
    "Penn State",
    "Purdue",
    "Rutgers",
    "Wisconsin"
};

app.MapGet("/teams", () => bigTenTeams);

app.Run();