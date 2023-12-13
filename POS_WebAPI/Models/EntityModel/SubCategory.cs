﻿using POS_WebAPI.Models.Constant;

namespace POS_WebAPI.Models.EntityModel
{
    public class SubCategory
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Image { get; set; }  
        public string Main_Category_Id { get; set; } = null!;
        public string? Description { get; set; } 
        public DateTime Create_At { get; set; }
        public Status Status { get; set; }
        public bool Is_Deleted { get; set; }
        //
        public ICollection<Product>? Products { get; set; }
        public Category Category { get; set; } = null!;
    }
}
