using ReviewWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewWebAPI.Repositories
{
    public interface IReviewRepository
    {
        Task<List<Review>> GetAll();
        Task<List<Review>> GetByItemName(string itemName);
        Task<Review> GetById(int id);
        Task<List<Review>> GetByRatingAsc();
        Task<List<Review>> GetByRatingDesc();
        Task AddReview(Review review);
        Task DeleteReview(int id);
    }
}
