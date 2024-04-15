using Tutorial5.Database;
using Tutorial5.Models;

namespace Tutorial5.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        // Pobieranie listy zwierząt
        app.MapGet("/animals", () =>
        {
            //200 - Ok
            //201 - Created
            //400 - Bad request
            //401 - Unauthorized
            //403 - Forbidden
            //404 - Not Found

            var animals = StaticData.animals;

            return Results.Ok(animals);
        });

        // Pobieranie konkretnego zwierzęcia po id
        app.MapGet("/animals/{id}", (int id) =>
        {
            var animal = StaticData.animals.FirstOrDefault(a => a.Id == id);
            if (animal != null)
            {
                return Results.Ok(animal);
            }
            else
            {
                return Results.NotFound();
            }
        });

        // Dodawanie zwierzęcia
        app.MapPost("/animals", (Animal animal) =>
        {
            StaticData.animals.Add(animal);
            return Results.Created("", animal);
        });

        
        // Edycja zwierzęcia
        app.MapPut("/animals/{id}", (int id, Animal updatedAnimal) =>
        {
            var existingAnimal = StaticData.animals.FirstOrDefault(a => a.Id == id);
            if (existingAnimal != null)
            {
                existingAnimal.Name = updatedAnimal.Name;
                existingAnimal.Category = updatedAnimal.Category;
                existingAnimal.Color = updatedAnimal.Color;
                existingAnimal.Weight = updatedAnimal.Weight;

                return Results.Ok(existingAnimal);
            }
            else
            {
                return Results.NotFound();
            }
        });
        
        // Usuwanie zwierzęcia
        app.MapDelete("/animals/{id}", (int id) =>
        {
            var animalToRemove = StaticData.animals.FirstOrDefault(a => a.Id == id);
            if (animalToRemove != null)
            {
                StaticData.animals.Remove(animalToRemove);
                return Results.Ok();
            }
            else
            {
                return Results.NotFound();
            }
        });
    }
}