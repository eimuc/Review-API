using Microsoft.EntityFrameworkCore;
using ReviewWebAPI.Data;
using ReviewWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewWebAPI.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ReviewContext _context;

        public ReviewRepository(ReviewContext context)
        {
            _context = context;
        }
        public async Task AddReview(Review review)
        {
            _context.Add(review);
           await  _context.SaveChangesAsync();
        }

        public async Task<List<Review>> GetAll()
        {
            return await _context.Reviews.ToListAsync();
        }

        public async Task<List<Review>> GetByItemName(string itemName)
        {
            return await _context.Reviews.Where(i => i.ItemName == itemName).ToListAsync();
        }

        public async Task<Review> GetById(int id)
        {
            return await _context.Reviews.FindAsync(id);
        }

        public async Task<List<Review>> GetByRatingAsc()
        {
            return await _context.Reviews.OrderBy(x => x.Rating).ToListAsync();
        }

        public async Task<List<Review>> GetByRatingDesc()
        {
            return await _context.Reviews.OrderByDescending(x => x.Rating).ToListAsync();
        }
        public async Task DeleteReview(int id)
        {
            var review = await GetById(id);
            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();
        }
    }
}
