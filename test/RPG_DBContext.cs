using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace test
{
    public partial class RPG_DBContext : DbContext
    {
        public RPG_DBContext()
            : base("name=RPG_DBContext")
        {
        }

        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<EquipmentType> EquipmentTypes { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Inventory_Equipment> Inventory_Equipment { get; set; }
        public virtual DbSet<Inventory_Items> Inventory_Items { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Passive> Passives { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<CharacterSkill> CharacterSkills { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>()
                .HasOptional(e => e.Inventory)
                .WithRequired(e => e.Character);

            modelBuilder.Entity<Character>()
                .HasMany(e => e.Passives)
                .WithMany(e => e.Characters)
                .Map(m => m.ToTable("Characters_Passives").MapLeftKey("Character_Id").MapRightKey("Passive_Name"));

            modelBuilder.Entity<Character>()
                .HasMany(e => e.Skills)
                .WithMany(e => e.Characters)
                .Map(m => m.ToTable("Characters_Skills").MapLeftKey("Character_Id").MapRightKey("Skill_Name"));

            modelBuilder.Entity<Equipment>()
                .HasMany(e => e.Characters)
                .WithOptional(e => e.Equipment)
                .HasForeignKey(e => e.Chest);

            modelBuilder.Entity<Equipment>()
                .HasMany(e => e.Characters1)
                .WithOptional(e => e.Equipment1)
                .HasForeignKey(e => e.Hands);

            modelBuilder.Entity<Equipment>()
                .HasMany(e => e.Characters2)
                .WithOptional(e => e.Equipment2)
                .HasForeignKey(e => e.Left_Hand);

            modelBuilder.Entity<Equipment>()
                .HasMany(e => e.Characters3)
                .WithOptional(e => e.Equipment3)
                .HasForeignKey(e => e.Right_Hand);

            modelBuilder.Entity<Equipment>()
                .HasMany(e => e.Characters4)
                .WithOptional(e => e.Equipment4)
                .HasForeignKey(e => e.Feet);

            modelBuilder.Entity<Equipment>()
                .HasMany(e => e.Characters5)
                .WithOptional(e => e.Equipment5)
                .HasForeignKey(e => e.Head);

            modelBuilder.Entity<Equipment>()
                .HasMany(e => e.Characters6)
                .WithOptional(e => e.Equipment6)
                .HasForeignKey(e => e.Legs);

            modelBuilder.Entity<Equipment>()
                .HasMany(e => e.Inventory_Equipment)
                .WithRequired(e => e.Equipment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EquipmentType>()
                .HasMany(e => e.Equipments)
                .WithRequired(e => e.EquipmentType1)
                .HasForeignKey(e => e.EquipmentType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inventory>()
                .HasMany(e => e.Inventory_Items)
                .WithRequired(e => e.Inventory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inventory>()
                .HasMany(e => e.Inventory_Equipment)
                .WithRequired(e => e.Inventory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Inventory_Items)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profile>()
                .HasMany(e => e.Characters)
                .WithRequired(e => e.Profile)
                .WillCascadeOnDelete(false);
        }
    }
}
