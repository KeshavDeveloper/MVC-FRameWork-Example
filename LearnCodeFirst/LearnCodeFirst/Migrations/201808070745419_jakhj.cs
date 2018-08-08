namespace LearnCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jakhj : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Students", newName: "StudentTable");
            RenameColumn(table: "dbo.StudentTable", name: "StudentUQId", newName: "Id");
            RenameColumn(table: "dbo.StudentTable", name: "Name", newName: "StudentName");
            AlterColumn("dbo.StudentTable", "StudentName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentTable", "StudentName", c => c.String());
            RenameColumn(table: "dbo.StudentTable", name: "StudentName", newName: "Name");
            RenameColumn(table: "dbo.StudentTable", name: "Id", newName: "StudentUQId");
            RenameTable(name: "dbo.StudentTable", newName: "Students");
        }
    }
}
