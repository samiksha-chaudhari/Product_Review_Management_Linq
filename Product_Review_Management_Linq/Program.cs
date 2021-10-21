using System;
using System.Collections.Generic;

namespace Product_Review_Management_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management using Linq");
            //creating list
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductId=1,UserId=1,Rating=5,Review="Good",isLike=true },
                new ProductReview(){ProductId=2,UserId=1,Rating=4,Review="Good",isLike=true },
                new ProductReview(){ProductId=3,UserId=2,Rating=5,Review="Good",isLike=true },
                new ProductReview(){ProductId=4,UserId=2,Rating=4,Review="Good",isLike=true },
                new ProductReview(){ProductId=5,UserId=3,Rating=2,Review="Nice",isLike=false},
                new ProductReview(){ProductId=6,UserId=4,Rating=1,Review="Bad",isLike=false },
                new ProductReview(){ProductId=7,UserId=3,Rating=1,Review="Nice",isLike=false },
                new ProductReview(){ProductId=8,UserId=10,Rating=9,Review="Nice",isLike=true },
                new ProductReview(){ProductId=9,UserId=10,Rating=10,Review="Nice",isLike=true },
                new ProductReview(){ProductId=10,UserId=10,Rating=8,Review="Nice",isLike=true },
                new ProductReview(){ProductId=11,UserId=10,Rating=3,Review="Nice",isLike=true },
                new ProductReview(){ProductId=12,UserId=10,Rating=7,Review="Nice",isLike=true },
                new ProductReview(){ProductId=13,UserId=10,Rating=2,Review="Nice",isLike=true },
                new ProductReview(){ProductId=14,UserId=10,Rating=4,Review="Nice",isLike=true },
                new ProductReview(){ProductId=15,UserId=10,Rating=4,Review="Nice",isLike=true },
                new ProductReview(){ProductId=16,UserId=10,Rating=4,Review="Nice",isLike=true }
            };           

            Management management = new Management();//creating object

            int defcount = 0;//counter to break the while loop

            while (defcount == 0)
            {               
                Console.WriteLine("1.Product Review  2.Top 3 Records  3.rating >3 and productID is 1 or 4 or 9  4.Using Linq Oprator  5.Retriving Product ID and review  6.Exit");
                Console.WriteLine("Choose Option :");
                int choice = Convert.ToInt32(Console.ReadLine());//variable for taking choice from the user

                switch (choice)  //switch case
                {
                    case 1:
                        foreach (var list in productReviewList)//to print list 
                        {
                            Console.WriteLine("ProductId:- " + list.ProductId + " " + "UserId:- " + list.UserId
                                + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike :- " + list.isLike);
                        }
                        break;

                    case 2:
                        //UC2
                        management.TopRecords(productReviewList);//calling TopRecords() 
                        break;
                    case 3:
                        //UC3
                        management.SelectedRecords(productReviewList);
                        break;
                    case 4:
                        //UC4
                        management.RetrieveCountOfRecords(productReviewList);
                        break;
                    case 5:
                        //UC5
                        management.RetrieveProductID(productReviewList);
                        break;
                    default:
                        Console.WriteLine("End");//default condition
                        defcount++;
                        break;

                }

            }
        }
    }
}