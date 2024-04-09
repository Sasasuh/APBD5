using Tutorial5.Models;

namespace Tutorial5.Database;

public class MockOb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public MockOb()
    {
        Animals.Add(new Animal());
        Animals.Add(new Animal());
        Animals.Add(new Animal());
        Animals.Add(new Animal());
    }
}