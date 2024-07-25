using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals_L09.Candle
{
    internal struct ProductReview
    {
        public string review;
        public int numberOfStars;

        public void DisplayRating()
        {
            Console.WriteLine($"Prouct review : {review}\nNumber of stars : {numberOfStars}/5");
        }
    }
}
