using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace JsonSerLaba.DBCon
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>()
                .Property(e => e.StartedAt)
                .HasPrecision(6);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Event)
                .WillCascadeOnDelete();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Activities)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.ModeratorID);
        }
    }
}
