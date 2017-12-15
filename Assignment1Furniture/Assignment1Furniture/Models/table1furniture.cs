namespace Assignment1Furniture.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class table1furniture
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand { get; set; }

        public int Price { get; set; }

        [Required]
        [StringLength(50)]
        public string RoomColor { get; set; }
    }
}
