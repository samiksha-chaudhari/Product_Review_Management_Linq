using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace Product_Review_Management_Linq
{
    class Management
    {
        public readonly DataTable dataTable = new DataTable();

        /// <summary>
        /// method to retrive top 2 records
        /// </summary>
        /// <param name="listProductReview"></param>
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:- " + list.ProductId + " " + "UserId:- " + list.UserId
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike :- " + list.isLike);
            }
        }
    }
}
