﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _23dh111130_MyStore.Models.ViewModel
{
    public class ProductDetailsVM
    {
        public Product product { get; set; }
        public int quantity { get; set; } = 1;
        //tính giá trị tạm thời
        public decimal estimatedValue => quantity * product.ProductPrice;
        //các thuộc tính hỗ trợ phân trang
        public int PageNumber { get; set; } // trang hiện tại
        public int PageSize { get; set; } = 3; // số sản phẩm mỗi trang 
                                               // danh sách 8 sản phẩm cùng danh mục
        public PagedList.IPagedList<Product> RelatedProducts { get; set; }
        //danh sách 8 sản phẩm cùng danh mục
        public PagedList.IPagedList<Product> TopProducts { get; set; }
    }
}