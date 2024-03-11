namespace SEDC.Lamazon.Domain.Entities;

public class Review
{
    public int Id { get; set; }
    public int Rating { get; set; }

    public string Comment { get; set; }

    public DateTime DateTime { get; set; }

    public int ProductId { get; set; }

    public int UserId { get; set; }
}
