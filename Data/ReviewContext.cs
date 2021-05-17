using Microsoft.EntityFrameworkCore;
using ReviewWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewWebAPI.Data
{
    public class ReviewContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }

        public ReviewContext(DbContextOptions<ReviewContext> options) : base(options)
        {
            //if (!Reviews.Any())
            //{
            //    Reviews.Add(new Review()
            //    {
            //        ItemName = "Gadget",
            //        Rating = 5,
            //        Comment = "sfsfsdfdsfdsfsdf"
            //    });

            //    SaveChanges();
            //}
        }
    }
}
