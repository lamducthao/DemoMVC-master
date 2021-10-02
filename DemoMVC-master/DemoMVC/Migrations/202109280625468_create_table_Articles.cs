namespace DemoMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_Articles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticlesID = c.String(nullable: false, maxLength: 128),
                        Author = c.String(),
                        Articlescontent = c.String(),
                    })
                .PrimaryKey(t => t.ArticlesID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Articles");
        }
    }
}
