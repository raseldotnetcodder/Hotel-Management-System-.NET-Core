using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        [Display(Name = "Invoice Number")]
        public int InvoiceNumber { get; set; }

        public int BookingId { get; set; }
        public Booking Booking { get; set; }

        public int SuplementaryId { get; set; }
        public IEnumerable<Suplementary> Suplementary { get; set; }

        public int ComplementaryId { get; set; }
        public IEnumerable<Complementary> Complementary { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Amount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? VAT { get; set; }

        [Display(Name = "Paid Amount")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? PaidAmount { get; set; }

        [Display(Name = "Due Amount")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? DueAmount { get; set; }

        [Display(Name = "Total Amount")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? TotalAmount { get; set; }

        public string Status { get; set; }

        [NotMapped]
        public IEnumerable<Invoice> Invoices { get; set; }
    }
}
