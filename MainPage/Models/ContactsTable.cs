namespace MainPage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactsTable")]
    public partial class ContactsTable
    {
        [Key]
        [StringLength(10)]
        public string ProductNumber { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string NumberOfProducts { get; set; }

        [StringLength(50)]
        public string Price { get; set; }

        [StringLength(50)]
        public string CommodityCategory { get; set; }
    }
}
