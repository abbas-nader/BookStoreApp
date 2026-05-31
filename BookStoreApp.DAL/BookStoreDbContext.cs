using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext() : base("Data Source=ABBAS\\SQL2022;Initial Catalog=BookStoreDb;Integrated Security=True;") {}
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Author>()
                 .Property(x => x.FirstName)
                 .IsRequired()
                 .HasMaxLength(50);
            modelBuilder.Entity<Author>()
                .Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<BookAuthor>()
                .HasRequired(x => x.Book)
                .WithMany(x => x.BookAuthors)
                .HasForeignKey(x => x.BookId);
            modelBuilder.Entity<BookAuthor>()
               .HasRequired(x => x.Author)
               .WithMany(x => x.BookAuthors)
               .HasForeignKey(x => x.AuthorId);
            modelBuilder.Entity<Book>()
                .Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(150);
            modelBuilder.Entity<Book>()
               .Property(x => x.Isbn)
               .HasColumnType("char")
               .IsRequired()
               .HasMaxLength(13);
            modelBuilder.Entity<Book>()
               .Property(x => x.Description)
               .IsRequired()
               .HasMaxLength(1000);
            modelBuilder.Entity<Category>()
              .Property(x => x.Name)
              .IsRequired()
              .HasMaxLength(50);
            modelBuilder.Entity<Publisher>()
              .Property(x => x.Name)
              .IsRequired()
              .HasMaxLength(50);
            modelBuilder.Entity<Book>()
                .HasRequired(x=> x.Publisher)
                .WithMany(x=>x.Books)
                .HasForeignKey(x=> x.PublisherId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Book>()
              .HasRequired(x => x.Category)
              .WithMany(x => x.Books)
              .HasForeignKey(x => x.CategoryId)
              .WillCascadeOnDelete(false);
        }
    }
}
