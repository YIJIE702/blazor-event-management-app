using EventEase.Server.Data;
using EventEase.Shared.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// Add in-memory data service
builder.Services.AddSingleton<InMemoryEventStore>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapRazorPages();
app.MapControllers();
// Minimal API endpoints for events and registrations
app.MapGet("/api/events", (InMemoryEventStore store) => Results.Ok(store.GetEvents()));
app.MapGet("/api/events/{id:int}", (int id, InMemoryEventStore store) =>
{
    var ev = store.GetEvent(id);
    return ev is null ? Results.NotFound() : Results.Ok(ev);
});
app.MapPost("/api/registrations", (RegistrationModel reg, InMemoryEventStore store) =>
{
    if (string.IsNullOrWhiteSpace(reg.Name) || string.IsNullOrWhiteSpace(reg.Email))
        return Results.BadRequest("Name and Email are required");
    store.AddRegistration(reg);
    return Results.Created($"/api/registrations/{reg.EventId}", reg);
});
app.MapGet("/api/registrations/{eventId:int}", (int eventId, InMemoryEventStore store) =>
{
    return Results.Ok(store.GetRegistrationsForEvent(eventId));
});

app.Run();
