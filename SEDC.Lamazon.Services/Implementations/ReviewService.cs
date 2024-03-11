using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Entities;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.Services.ViewModels.Review;

namespace SEDC.Lamazon.Services.Implementations;

public class ReviewService : IReviewService
{
    private readonly IReviewRepository _reviewRepository;   

    public ReviewService(IReviewRepository reviewRepository)
    {
        _reviewRepository = reviewRepository;
    }   

    public void CreateReview(ReviewViewModel model)
    {


        Review review = new Review()
        {
            Comment = model.Comment,
            DateTime = model.DateTime,
            Id = model.Id,
            ProductId = model.ProductId,
            Rating = model.Rating,
            UserId = model.UserId
        };

        int reviewId = _reviewRepository.Insert(review);

        if (reviewId == 0)
            throw new Exception("Something went wrong!");
    }

    public List<ReviewViewModel> GetAllReviews()
    {
        //throw new NotImplementedException();

        List<ReviewViewModel> reviewList = _reviewRepository
           .GetAll()
           .Select(p => new ReviewViewModel()
           {
              Comment = p.Comment,  
              DateTime = p.DateTime,
              Id = p.Id,
              ProductId= p.ProductId,
              Rating= p.Rating,
              UserId = p.UserId 
           })
           .ToList();

        return reviewList;
    }
}
