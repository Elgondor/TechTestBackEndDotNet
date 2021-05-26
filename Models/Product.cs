using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QandA.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }
        [MaxLength(300)]
        public string ProductDescription { get; set; }
        [Required]
        [DisplayName("Category")]
        public string CategoryId { get; set; }
        //[Required]
        //public double QuantityPerUnit { get; set; }
        //[Required]
        //public double UnitPrice { get; set; }
        //[Required]
        //public double MSRP { get; set; }
        //public double AvailableSize { get; set; }
        //public string AvailableColor { get; set; }
        //public double Discount { get; set; }
        //[Required]
        //public double UnitWeight { get; set; }
        //[Required]
        //public double UnitsInStock { get; set; }
        //public double UnitsOnOrder { get; set; }
        //public double ProductAvailability { get; set; }
        //public string Picture { get; set; }
        //public string Note { get; set; }
    }
}
