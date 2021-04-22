namespace trial3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventory")]
    public partial class Inventory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inventory()
        {
            Inventory_Items = new HashSet<Inventory_Items>();
            Inventory_Equipment = new HashSet<Inventory_Equipment>();
        }

        [Key]
        public int Inventory_Id { get; set; }

        public int Character_Id { get; set; }

        public int Maximum_Space { get; set; }

        public int Occupied_Space { get; set; }

        public virtual Character Character { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory_Items> Inventory_Items { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory_Equipment> Inventory_Equipment { get; set; }
    }
}
