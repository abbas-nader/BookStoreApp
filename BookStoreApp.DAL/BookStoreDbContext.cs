using BookStoreApp.DAL.Entities;
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
        public BookStoreDbContext() : base("Data Source=ABBAS\\SQL2022;Initial Catalog=BookStoreDb;Integrated Security=True;") { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Translator> Translators { get; set; }
        public DbSet<BookTranslator> BookTranslators { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
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
                .HasRequired(x => x.Publisher)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.PublisherId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Book>()
              .HasRequired(x => x.Category)
              .WithMany(x => x.Books)
              .HasForeignKey(x => x.CategoryId)
              .WillCascadeOnDelete(false);
            modelBuilder.Entity<BookTranslator>()
               .HasRequired(x => x.Book)
               .WithMany(x => x.BookTranslators)
               .HasForeignKey(x => x.BookId);
            modelBuilder.Entity<BookTranslator>()
               .HasRequired(x => x.Translator)
               .WithMany(x => x.BookTranslators)
               .HasForeignKey(x => x.TranslatorId);
            modelBuilder.Entity<Translator>()
                 .Property(x => x.FirstName)
                 .IsRequired()
                 .HasMaxLength(50);
            modelBuilder.Entity<Translator>()
                .Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
    .Property(x => x.FirstName)
    .IsRequired()
    .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(x => x.Username)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Customer>()
    .Property(x => x.FirstName)
    .IsRequired()
    .HasMaxLength(50);
            modelBuilder.Entity<Customer>()
                .Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Customer>()
                .Property(x => x.Phone)
                .HasMaxLength(11);
            modelBuilder.Entity<Order>()
    .HasRequired(x => x.User)
    .WithMany(x => x.Orders)
    .HasForeignKey(x => x.UserId)
    .WillCascadeOnDelete(false);
            modelBuilder.Entity<Order>()
                .HasRequired(x => x.Customer)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.CustomerId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Order>()
                .Property(x => x.TotalAmount)
                .HasPrecision(18, 2);
            modelBuilder.Entity<OrderItem>()
    .HasRequired(x => x.Order)
    .WithMany(x => x.OrderItems)
    .HasForeignKey(x => x.OrderId);
            modelBuilder.Entity<OrderItem>()
                .HasRequired(x => x.Book)
                .WithMany()
                .HasForeignKey(x => x.BookId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<OrderItem>()
                .Property(x => x.UnitPrice)
                .HasPrecision(18, 2);
        }
    }
}
