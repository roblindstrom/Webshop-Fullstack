using System;

namespace WebshopShared.DTOModels
{
    public class DTOItem
    {
        public Guid ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Published { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
        public string PictureSourcePath { get; set; }
    }
}
