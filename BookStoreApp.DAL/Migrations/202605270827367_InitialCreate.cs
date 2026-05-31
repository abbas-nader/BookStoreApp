namespace BookStoreApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        CreationBy = c.Int(nullable: false),
                        LastModifiedTime = c.DateTime(),
                        LastModifiedBy = c.Int(),
                        DeletedTime = c.DateTime(),
                        DeletedBy = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        AuthorId = c.Int(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreationBy = c.Int(nullable: false),
                        LastModifiedTime = c.DateTime(),
                        LastModifiedBy = c.Int(),
                        DeletedTime = c.DateTime(),
                        DeletedBy = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Isbn = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StockQuentity = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        PublisherId = c.Int(nullable: false),
                        PublicationYear = c.Int(nullable: false),
                        Description = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        CreationBy = c.Int(nullable: false),
                        LastModifiedTime = c.DateTime(),
                        LastModifiedBy = c.Int(),
                        DeletedTime = c.DateTime(),
                        DeletedBy = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        CreationBy = c.Int(nullable: false),
                        LastModifiedTime = c.DateTime(),
                        LastModifiedBy = c.Int(),
                        DeletedTime = c.DateTime(),
                        DeletedBy = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        CreationBy = c.Int(nullable: false),
                        LastModifiedTime = c.DateTime(),
                        LastModifiedBy = c.Int(),
                        DeletedTime = c.DateTime(),
                        DeletedBy = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Publishers");
            DropTable("dbo.Categories");
            DropTable("dbo.Books");
            DropTable("dbo.BookAuthors");
            DropTable("dbo.Authors");
        }
    }
}
