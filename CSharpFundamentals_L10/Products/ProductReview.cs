using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals_L10.Products
{
    public struct ProductReview
    {
        private string review;
        private int numberOfStars;

        public ProductReview(string review, int numberOfStars)
        {
            Review = review;
            NumberOfStars = numberOfStars;
        }

        public string Review
        {
            get { return review; }
            set { review = value; }

        }

        public int NumberOfStars
        {
            get { return numberOfStars; }
            set { numberOfStars = value; }
        }

        public void DisplayRating()
        {
            Console.WriteLine($"Prouct review : {review}\nNumber of stars : {numberOfStars}/5");
        }
    }
}
