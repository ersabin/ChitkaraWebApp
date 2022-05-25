using Microsoft.EntityFrameworkCore;

namespace ChitkaraWebApp.Models
{
    public partial class ChitkaraContext : DbContext
    {
        public ChitkaraContext()
        {
        }

        public ChitkaraContext(DbContextOptions<ChitkaraContext> options)
            : base(options)
        {
        }

        public virtual DbSet<StudentDetails> StudentDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Chitkara;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentDetails>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.StudentDepartment)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StudentName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
