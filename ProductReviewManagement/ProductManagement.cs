﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReviewManagement
{
    /// <summary>
    /// UC1- Product Infromation
    /// </summary>
    public class ProductManagement
    {
        /// <summary>
        /// UC-2 Top three records
        /// </summary>
        /// <param name="reviews"></param>
        public static void TopRecords(List<ProductReview> reviews)
        {
            var record = (from productReviews in reviews
                          orderby productReviews.Rating descending
                          select productReviews).Take(3);
            foreach (var list in record)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " +
                        "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);
            }
        }
    }
}
