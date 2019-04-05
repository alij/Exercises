using Post.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.DAL
{
    public class ReviewSqlDAO : IReviewDAO
    {
        private readonly string connectionString;

        public ReviewSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Returns a list of all reviews
        /// </summary>
        /// <returns></returns>
        public List<Review> GetAllReviews()
        {
            List<Review> reviews = new List<Review>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("select * from reviews;", connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Review review = new Review();

                        review.Username = Convert.ToString(reader["username"]);
                        review.Rating = Convert.ToInt32(reader["rating"]);
                        review.ReviewTitle = Convert.ToString(reader["review_title"]);
                        review.ReviewText = Convert.ToString(reader["review_text"]);
                        review.ReviewDate = Convert.ToDateTime(reader["review_date"]);

                        reviews.Add(review);

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return reviews;

        }

        /// <summary>
        /// Saves a new review to the system.
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns></returns>
        public int SaveReview(Review newReview)
        {
            int submittal = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("insert into reviews values (@username, @rating, @review_title, @review_text, @review_date);", connection);
                    cmd.Parameters.AddWithValue("@username", newReview.Username);
                    cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                    cmd.Parameters.AddWithValue("@review_title", newReview.ReviewTitle);
                    cmd.Parameters.AddWithValue("@review_text", newReview.ReviewText);
                    cmd.Parameters.AddWithValue("@review_date", newReview.ReviewDate);

                    submittal = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return submittal;
        }
    }
}
