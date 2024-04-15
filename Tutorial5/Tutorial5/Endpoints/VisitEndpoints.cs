using Tutorial5.Database;
using Tutorial5.Models;

namespace Tutorial5.Endpoints;

public static class VisitEndpoints
{
    public static void MapVisitEndpoints(this WebApplication app)
    {
        // Pobieranie listy wizyt powiązanych z danym zwierzęciem
        app.MapGet("/visits/{animalId}", (int animalId) =>
        {
            var visits = StaticData.visits.Where(v => v.AnimalId == animalId).ToList();
            return Results.Ok(visits);
        });

        // Dodawanie nowej wizyty
        app.MapPost("/visits", (Visit visit) =>
        {
            visit.Id = Guid.NewGuid();
            StaticData.visits.Add(visit);
            return Results.Created($"/visits/{visit.Id}", visit);
        });
    }
}