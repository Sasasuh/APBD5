namespace Tutorial5.Models;

public class Visit
{
    public Guid Id { get; set; }
    public DateTime VisitDate { get; set; }
    public int AnimalId { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
}