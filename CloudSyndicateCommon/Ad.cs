using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CloudSyndicateCommon
{
    public enum Category
    {
        [Display(Name="Compute")]
        Compute,
        [Display(Name = "AI")]
        ArtificialIntelligence,
	[Display(Name = "Analytics")]
        Analytics,
	[Display(Name = "Containers")]
        Containers,
	[Display(Name = "DataBases")]
        DataBases,
	[Display(Name = "DevOps")]
        DevOps,
	[Display(Name = "IoT")]
        InternetofThings,
	[Display(Name = "Storage")]
        Storage,
	[Display(Name = "Web")]
        Web,
	[Display(Name = "DR")]
        DisasterRecovery,
	[Display(Name = "Security")]
        Security,
    }
    public class Ad
    {
        public int AdId { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public int Price { get; set; }
        [StringLength(1000)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [StringLength(2083)]
        [DisplayName("Full-size Image")]
        public string ImageURL { get; set; }
        [StringLength(2083)]
        [DisplayName("Thumbnail")]
        public string ThumbnailURL { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PostedDate { get; set; }
        public Category? Category { get; set; }
        [StringLength(12)]
        public string Phone { get; set; }
    }

}

