using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.Services.ViewModels.Review;
using System.Security.Claims;

namespace SEDC.Lamazon.Web.Controllers
{
    public class ReviewController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;
        private readonly IOrderItemService _orderItemService;
        private readonly IReviewService _reviewService;


        public ReviewController(ILogger<HomeController> logger,
            IProductService productService,
            IOrderService orderService,
            IOrderItemService orderItemService,
            IReviewService reviewService)
        {
            _logger = logger;
            _productService = productService;
            _orderService = orderService;
            _orderItemService = orderItemService;
            _reviewService = reviewService;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [Authorize(Roles = "User")]
        public IActionResult AddReview(ReviewViewModel model)
        {

            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int userId = int.Parse(currentUserId);

            if (userId == null)
            {
                return RedirectToAction("Login", "Account");
            }

            ReviewViewModel reviewViewModel = new ReviewViewModel()
            {
                Comment = model.Comment,
                DateTime = DateTime.Now,
                UserId = userId,
                Rating = model.Rating,
                ProductId = model.ProductId,
            };

            _reviewService.CreateReview(reviewViewModel);

            return View(model);  
        }
    }
}
