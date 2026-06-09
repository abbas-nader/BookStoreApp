namespace BookStoreApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtranslatorentity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookTranslators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        TranslatorId = c.Int(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreationBy = c.Int(nullable: false),
                        LastModifiedTime = c.DateTime(),
                        LastModifiedBy = c.Int(),
                        DeletedTime = c.DateTime(),
                        DeletedBy = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Translators", t => t.TranslatorId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.TranslatorId);
            
            CreateTable(
                "dbo.Translators",
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookTranslators", "TranslatorId", "dbo.Translators");
            DropForeignKey("dbo.BookTranslators", "BookId", "dbo.Books");
            DropIndex("dbo.BookTranslators", new[] { "TranslatorId" });
            DropIndex("dbo.BookTranslators", new[] { "BookId" });
            DropTable("dbo.Translators");
            DropTable("dbo.BookTranslators");
        }
    }
}
