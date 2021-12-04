using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Commerce.Models;

#nullable disable

namespace Commerce.Repository
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<LoginHistory> LoginHistories { get; set; }
        public virtual DbSet<NotficationRule> NotficationRules { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Trigger> Triggers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=MIR\\SQLEXPRESS;Initial Catalog=COMMERCE;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.AccountNum)
                    .HasName("PK__Account__EFC6E169158B7F1F");

                entity.Property(e => e.AccountNum).IsUnicode(false);

                entity.Property(e => e.AccountType).IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => new { e.AccountNumber, e.UserId })
                    .HasName("PK__Customer__0D0F85759A4FCD7E");

                entity.Property(e => e.AccountNumber).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fK_id");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Login__206D9190DD9AC0B5");

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.UserName).IsUnicode(false);

                entity.Property(e => e.UserPassword).IsUnicode(false);
            });

            modelBuilder.Entity<LoginHistory>(entity =>
            {
                entity.HasKey(e => e.Lhid)
                    .HasName("PK__LoginHis__60E2EAC866979A39");

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LoginHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__LoginHist__UserI__5812160E");
            });

            modelBuilder.Entity<NotficationRule>(entity =>
            {
                entity.HasKey(e => e.Nrid)
                    .HasName("PK__Notficat__E2F663718B163974");

                entity.Property(e => e.AccountNumber).IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.Property(e => e.NotificationId).IsUnicode(false);

                entity.Property(e => e.AccNumber).IsUnicode(false);

                entity.Property(e => e.NotificationMessage).IsUnicode(false);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.Property(e => e.TransactionId).IsUnicode(false);

                entity.Property(e => e.AccountNo).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.TransactionType).IsUnicode(false);
            });

            modelBuilder.Entity<Trigger>(entity =>
            {
                entity.Property(e => e.TriggerId).IsUnicode(false);

                entity.Property(e => e.TriggerDescription).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
