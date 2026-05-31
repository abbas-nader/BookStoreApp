namespace BookStoreApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookCoreRelations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "StockQuantity", c => c.Int(nullable: false));
            AlterColumn("dbo.Authors", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Authors", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Books", "Isbn", c => c.String(nullable: false, maxLength: 13, fixedLength: true, unicode: false));
            AlterColumn("dbo.Books", "Description", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Publishers", "Name", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.BookAuthors", "BookId");
            CreateIndex("dbo.BookAuthors", "AuthorId");
            CreateIndex("dbo.Books", "CategoryId");
            CreateIndex("dbo.Books", "PublisherId");
            AddForeignKey("dbo.BookAuthors", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Books", "CategoryId", "dbo.Categories", "Id");
            AddForeignKey("dbo.Books", "PublisherId", "dbo.Publishers", "Id");
            AddForeignKey("dbo.BookAuthors", "BookId", "dbo.Books", "Id", cascadeDelete: true);
            DropColumn("dbo.Books", "StockQuentity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "StockQuentity", c => c.Int(nullable: false));
            DropForeignKey("dbo.BookAuthors", "BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "PublisherId", "dbo.Publishers");
            DropForeignKey("dbo.Books", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.BookAuthors", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "PublisherId" });
            DropIndex("dbo.Books", new[] { "CategoryId" });
            DropIndex("dbo.BookAuthors", new[] { "AuthorId" });
            DropIndex("dbo.BookAuthors", new[] { "BookId" });
            AlterColumn("dbo.Publishers", "Name", c => c.String());
            AlterColumn("dbo.Categories", "Name", c => c.String());
            AlterColumn("dbo.Books", "Description", c => c.String());
            AlterColumn("dbo.Books", "Isbn", c => c.String());
            AlterColumn("dbo.Books", "Title", c => c.String());
            AlterColumn("dbo.Authors", "LastName", c => c.String());
            AlterColumn("dbo.Authors", "FirstName", c => c.String());
            DropColumn("dbo.Books", "StockQuantity");
        }
    }
}
