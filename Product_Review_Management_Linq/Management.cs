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

        //UC2

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

        //UC3
        /// <summary>
        /// method to retrive record rating >3 and productID is 1 or 4 or 9 
        /// </summary>
        /// <param name="listProductReview"></param>
        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.ProductId == 1 ||
                                     productReviews.ProductId == 4 ||
                                     productReviews.ProductId == 9) && (productReviews.Rating > 3)
                               select productReviews;

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:- " + list.ProductId + " " + "UserId:- " + list.UserId
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike :- " + list.isLike);
            }
        }
        //UC4
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });

            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductId + "------" + list.Count);
            }
        }
        /// <summary>
        /// method to retrive product ID and Review
        /// </summary>
        /// <param name="listProductReview"></param>
        //UC5
        public void RetrieveProductID(List<ProductReview> listProductReview)
        {
            var recordedData = (from list in listProductReview
                                select new { list.ProductId, list.Review });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ToString());
            }

        }

        //UC6
        public void SkipTopFive(List<ProductReview> listProductReview)
        {
            var recordedData = (from list in listProductReview
                                orderby list.Rating descending
                                select list);
            foreach (var element in recordedData.Skip(5))
            {
                Console.WriteLine(element.ToString());
            }

        }
    }
}
