namespace test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CharacterSkill
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Character_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(18)]
        public string Character_Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string Skill_Name { get; set; }
    }
}
