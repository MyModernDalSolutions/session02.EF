using System.Collections.Generic;

namespace Session02.BeginingEF
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        #region نکته
        //چرا لیست محصولات را 
        //new
        //کرده ایم؟
        //جواب
        //ممکن است هنگام استفاده یادمان برود چک کنیم نال است یا خیر 
        #endregion
    }
}
