using SEDC.Lamazon.Services.ViewModels.Product;
using SEDC.Lamazon.Services.ViewModels.Review;

namespace SEDC.Lamazon.Services.Interfaces;

public interface IReviewService
{
    List<ReviewViewModel> GetAllReviews();
    void CreateReview(ReviewViewModel model);
}
