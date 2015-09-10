using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI.Entities
{
    public class DealerMetaData
    {
        [Required(ErrorMessage = "Please enter dealer name")]
        [Display(Name = "Dealer Name")]
        public string DealerName { get; set; }

        [Display(Name = "Website")]
        public string WebsiteURL { get; set; }

        [Required(ErrorMessage = "Please enter dealer email")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid email")]
        public string ContactEmail { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
    }

    public class DealerCityMetaData
    {
        [Required(ErrorMessage="Please select location from list")]
        [Display(Name="Location (Suburb, State, Post Code")]
        public int CityId { get; set; }

        [Required(ErrorMessage="Please enter street address")]
        [Display(Name="Street Address")]
        public string StreetAddress { get; set; }

        [RegularExpression(@"^\({0,1}((0|\+61)(2|4|3|7|8)){0,1}\){0,1}(\ |-){0,1}[0-9]{2}(\ |-){0,1}[0-9]{2}(\ |-){0,1}[0-9]{1}(\ |-){0,1}[0-9]{3}$", ErrorMessage = "Invalid phone number")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }

    public class SubBrandMetaData
    {
        [Required(ErrorMessage = "Please enter web sub brand name")]
        public string WebSubBrandName { get; set; }
    }

    public class FinishMetaData
    {
        [Required( ErrorMessage="Please enter finish name")]
        [Display(Name="Finish Name")]
        public string FinishName { get; set; }
        [Required(ErrorMessage = "Please upload an image")]
        [Display(Name = "Finish Image")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Please select brand")]
        [Display(Name = "Brand")]
        public int BrandId { get; set; }
    }

    public class ItemMetaData
    {
        [Display(Name = "Stock Code")]
        public string StockCode { get; set; }

        [Display(Name = "Product EXO Name")]
        public string ItemName { get; set; }

        [Display(Name = "RRP Price")]
        public Nullable<decimal> RRPPrice { get; set; }

        [Display(Name = "Availablilty Status")]
        public Nullable<int> AvailabilityStatusId { get; set; }

        [Display(Name = "Quantity")]
        public Nullable<int> Quantity { get; set; }

        [Display(Name = "Brand")]
        public Nullable<int> BrandId { get; set; }

        [Display(Name = "Sub Brand")]
        public Nullable<int> SubBrandId { get; set; }

        [Display(Name = "Web Product Name")]
        public string WebItemName { get; set; }

        [Display(Name = "Category")]
        public Nullable<int> CategoryId { get; set; }

        [Display(Name = "Description")]
        public string ProductDescription { get; set; }

        [Display(Name = "Box Size")]
        public decimal BoxSize { get; set; }

        [Display(Name = "Box Weight")]
        public decimal BoxWeight { get; set; }

        [Display(Name = "Product Specifications")]
        public string ProductSpecs { get; set; }
    }
    public class ItemColorMetaData
    {
        [Display(Name = "Finish")]
        public Nullable<int> FinishId { get; set; }
        [Display(Name = "Color")]
        public string ColorHex { get; set; }
        [Display(Name = "Default?")]
        public bool IsDefault { get; set; }
        [Display(Name = "Stock Code")]
        [Required(ErrorMessage = "Please enter stock code")]
        public string StockCode { get; set; }
    }

    public class WebsiteMetaData
    {
        [Display(Name = "Website Name")]
        public string WebsiteName { get; set; }
        [Display(Name = "Website Url")]
        public string WebsiteURL { get; set; }
        [Display(Name = "Website Logo")]
        public string LogoUrl { get; set; }
        [Display(Name = "Website Icon")]
        public string IconUrl { get; set; }
        [Display(Name = "Phone Number")]
        [RegularExpression(@"^\({0,1}((0|\+61)(2|4|3|7|8)){0,1}\){0,1}(\ |-){0,1}[0-9]{2}(\ |-){0,1}[0-9]{2}(\ |-){0,1}[0-9]{1}(\ |-){0,1}[0-9]{3}$", ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Sales Email")]
        [EmailAddress(ErrorMessage="Invalid Email")]
        public string SalesEmail { get; set; }
        [Display(Name = "Admin Email")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string AdminEmail { get; set; }
    }

    public class GroupMetaData
    {
        [Required(ErrorMessage="Please enter group name")]
        [Display(Name="Group Name")]
        public string GroupName { get; set; }
    }
    public partial class ColorMetaData
    {
        [Display(Name = "Color Name")]
        public string ColorName { get; set; }

        [Display(Name = "Choose Color")]
        public string ColorHex { get; set; }
    }
}
