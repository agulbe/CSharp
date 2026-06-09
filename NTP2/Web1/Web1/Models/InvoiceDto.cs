using System.ComponentModel.DataAnnotations;

namespace Web1.Models
{
    public class InvoiceDto
    {
        [Required]
        public string? Number { get; set; } = "";
        [Required]
        public string? Status { get; set; } = "";
        public DateOnly? IssueDate { get; set; }
        public DateOnly? DueDate { get; set; }

        // Servis ayrıntıları
        [Required]
        public string? Service { get; set; } = "";
        [Range(1, 999999, ErrorMessage = "Birim fiyat geçerli değil. 1-999999 arasında bir değer giriniz.")]
        public decimal UnitPrice { get; set; }
        [Range(1, 99, ErrorMessage = "Miktar geçerli değil. Lütfen 1-99 arasında bir tam sayı giriniz.")]
        public int Quantity { get; set; }

        // İstemci ayrıntıları
        [Required(ErrorMessage = "Müşteri adını lütfen giriniz.")]
        public string? ClientName { get; set; } = "";
        [Required, EmailAddress]
        public string? Email { get; set; } = "";
        [Phone]
        public string Phone { get; set; } = "";
        public string? Address { get; set; } = "";

    }
}
