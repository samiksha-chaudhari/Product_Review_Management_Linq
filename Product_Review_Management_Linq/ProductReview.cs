using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Review_Management_Linq
{
    class ProductReview
    {
        //using properties
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }
    }
}
