namespace SeriesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Series", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.Series", new[] { "Genre_ID" });
            AddColumn("dbo.Series", "Genre_ID1", c => c.Int());
            AlterColumn("dbo.Series", "Genre_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Series", "Genre_ID1");
            AddForeignKey("dbo.Series", "Genre_ID1", "dbo.Genres", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Series", "Genre_ID1", "dbo.Genres");
            DropIndex("dbo.Series", new[] { "Genre_ID1" });
            AlterColumn("dbo.Series", "Genre_ID", c => c.Int());
            DropColumn("dbo.Series", "Genre_ID1");
            CreateIndex("dbo.Series", "Genre_ID");
            AddForeignKey("dbo.Series", "Genre_ID", "dbo.Genres", "ID");
        }
    }
}
