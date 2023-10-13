using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BannerArt.Models
{
    public class Flag
    {
        
        public int Id { get; set; }
        public string FlagName { get; set; }

        public string DesignerName { get; set; }
        public string Material{ get; set; }
        public string Size { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal Price { get; set; }
        
        [Range(1, 5, ErrorMessage = "Customer review must be between 1 and 5.")]
        public double CustomerReview { get; set; }
        public string Rating{ get; set; }
    }
}


