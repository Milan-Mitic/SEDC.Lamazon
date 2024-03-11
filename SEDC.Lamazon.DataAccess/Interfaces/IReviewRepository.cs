using SEDC.Lamazon.Domain.Entities;

namespace SEDC.Lamazon.DataAccess.Interfaces;

public interface IReviewRepository
{

    List<Review> GetAll();
    int Insert(Review review);
}
