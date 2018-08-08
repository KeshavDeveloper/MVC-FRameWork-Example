namespace LearnCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdf : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentUQId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.String(),
                        Grade = c.String(),
                    })
                .PrimaryKey(t => t.StudentUQId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
