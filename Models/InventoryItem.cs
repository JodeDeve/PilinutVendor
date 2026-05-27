using System.ComponentModel.DataAnnotations;

namespace PilinutVendorSystem.Models
{
    public enum CategoryType
    {
        [Display(Name = "Honey Glazed Crispy Pili")]
        HoneyGlazedCrispy,
        [Display(Name = "Salted Caramel Crispy Pili")]
        SaltedCaramelCrispy,
        [Display(Name = "Salted Pili")]
        SaltedPili,
        [Display(Name = "Roasted Pili")]
        RoastedPili,
        [Display(Name = "Sweet Chilli Pili")]
        SweetChilliPili
    }

    public enum UnitType
    {
        [Display(Name = "Kilogram (kg)")]
        Kilogram,
        [Display(Name = "Gram (g)")]
        Gram,
        [Display(Name = "Pound (lbs)")]
        Pound,
        [Display(Name = "Piece (pcs)")]
        Piece
    }

    public class InventoryItem
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Item name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        public CategoryType Category { get; set; }

        [Range(0, 10000)]
        public decimal Quantity { get; set; }

        [Required]
        [Display(Name = "Unit")]
        public UnitType Unit { get; set; }

        [Range(0.0, 9999.99)]
        [DataType(DataType.Currency)]
        [Display(Name = "Price (PHP)")]
        public decimal Price { get; set; }

        public string? ImagePath { get; set; }

        /// <summary>
        /// Gets the image path - returns uploaded image if available, otherwise returns default category image
        /// </summary>
        public string GetImagePath()
        {
            // If user uploaded an image, use that
            if (!string.IsNullOrEmpty(ImagePath))
                return ImagePath;

            // Return default image based on category
            var defaultImages = new Dictionary<CategoryType, string>
            {
                { CategoryType.HoneyGlazedCrispy, "/images/products/HoneyGlazed.jpg" },
                { CategoryType.SaltedCaramelCrispy, "/images/products/saltedCaramelPili.jpg" },
                { CategoryType.SaltedPili, "/images/products/saltedPili.jpg" },
                { CategoryType.RoastedPili, "/images/products/roastedPili.jpg" },
                { CategoryType.SweetChilliPili, "/images/products/CrispyPili.jpg" }
            };

            return defaultImages.ContainsKey(Category) 
                ? defaultImages[Category] 
                : "/images/products/saltedPili.jpg"; // Fallback to salted pili
        }
    }
}
