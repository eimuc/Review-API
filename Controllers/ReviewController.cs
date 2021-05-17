using Microsoft.AspNetCore.Mvc;
using ReviewWebAPI.Models;
using ReviewWebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewController(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }
        [HttpGet]
        public async Task<List<Review>> GetAll()
        {
            return await _reviewRepository.GetAll();
        }
        [HttpGet("{itemName}")]
        public async Task<List<Review>> GetByItemName(string itemName)
        {
            return await _reviewRepository.GetByItemName(itemName);
        }
        [HttpGet]
        [Route("/[controller]/rating/asc/")]
        public async Task<List<Review>> GetByRatingAsc()
        {
            return await _reviewRepository.GetByRatingAsc();
        }
        [HttpGet]
        [Route("/[controller]/rating/desc/")]
        public async Task<List<Review>> GetByRatingDesc()
        {
            return await _reviewRepository.GetByRatingDesc();
        }
        [HttpPost]
        public async Task AddReview(Review review)
        {
            await _reviewRepository.AddReview(review);
        }
        [HttpDelete]
        public async Task DeleteReview(int id)
        {
            await _reviewRepository.DeleteReview(id);
        }
    }
}
