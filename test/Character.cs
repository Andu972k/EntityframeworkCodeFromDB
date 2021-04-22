namespace test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Character
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Character()
        {
            Passives = new HashSet<Passive>();
            Skills = new HashSet<Skill>();
        }

        [Key]
        public int Character_Id { get; set; }

        [Required]
        [StringLength(18)]
        public string Character_Name { get; set; }

        public int HP { get; set; }

        public int Atk { get; set; }

        public int Def { get; set; }

        public int UID { get; set; }

        public short? Head { get; set; }

        public short? Chest { get; set; }

        public short? Hands { get; set; }

        public short? Legs { get; set; }

        public short? Feet { get; set; }

        public short? Left_Hand { get; set; }

        public short? Right_Hand { get; set; }

        public virtual Equipment Equipment { get; set; }

        public virtual Equipment Equipment1 { get; set; }

        public virtual Equipment Equipment2 { get; set; }

        public virtual Equipment Equipment3 { get; set; }

        public virtual Equipment Equipment4 { get; set; }

        public virtual Equipment Equipment5 { get; set; }

        public virtual Equipment Equipment6 { get; set; }

        public virtual Profile Profile { get; set; }

        public virtual Inventory Inventory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Passive> Passives { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Skill> Skills { get; set; }
    }
}
