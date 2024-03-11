using Microsoft.EntityFrameworkCore;
using SEDC.Lamazon.DataAccess.Context;
using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Entities;

namespace SEDC.Lamazon.DataAccess.Implementations;

public class ReviewRepository : IReviewRepository
{
    private readonly LamazonDbContext _lamazonDbContext;

    public ReviewRepository(LamazonDbContext lamazonDbContext)
    {
        _lamazonDbContext = lamazonDbContext;
    }

    public List<Review> GetAll()
    {
        List<Review> reviews = _lamazonDbContext
           .Reviews
           .ToList();

        return reviews;
    }

    public int Insert(Review review)
    {
        _lamazonDbContext.Reviews.Add(review);
        _lamazonDbContext.SaveChanges();

        return review.Id;
    }
}
