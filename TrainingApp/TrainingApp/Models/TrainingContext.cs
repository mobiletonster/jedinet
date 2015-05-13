namespace TrainingApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TrainingContext : DbContext
    {
        public TrainingContext()
            : base("name=TrainingContext")
        {
        }

        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<Presenter> Presenters { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<TrainingPresenter> TrainingPresenters { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Participant>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Presenter>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Presenter>()
                .Property(e => e.Biography)
                .IsUnicode(false);

            modelBuilder.Entity<Presenter>()
                .Property(e => e.Avatar)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}
