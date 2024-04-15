using Tutorial5.Models;

namespace Tutorial5.Database;

public class StaticData
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal(),
        new Animal(),
        new Animal()
    };

    public static List<Visit> visits = new List<Visit>()
    {
        new Visit(),
        new Visit(),
        new Visit()
    };
}