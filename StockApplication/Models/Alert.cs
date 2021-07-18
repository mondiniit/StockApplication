using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using  System.Data.SQLite;

namespace StockApplication.Models
{
    public class Alert : IEnumerable
    {
        [NotNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Symbol { get; set; }
        public decimal AlertPrice { get; set; }
        public string Email { get; set; }
        public Byte[] Sent{ get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}