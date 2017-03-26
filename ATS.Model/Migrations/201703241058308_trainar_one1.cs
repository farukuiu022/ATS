namespace test1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trainar_one1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Trainers", "Institute_Id", "dbo.Institutes");
            DropIndex("dbo.Trainers", new[] { "Institute_Id" });
            RenameColumn(table: "dbo.Trainers", name: "Institute_Id", newName: "InstituteId");
            AlterColumn("dbo.Trainers", "InstituteId", c => c.Int(nullable: false));
            CreateIndex("dbo.Trainers", "InstituteId");
            AddForeignKey("dbo.Trainers", "InstituteId", "dbo.Institutes", "Id", cascadeDelete: true);
            DropColumn("dbo.Trainers", "InstituteIed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trainers", "InstituteIed", c => c.Int(nullable: false));
            DropForeignKey("dbo.Trainers", "InstituteId", "dbo.Institutes");
            DropIndex("dbo.Trainers", new[] { "InstituteId" });
            AlterColumn("dbo.Trainers", "InstituteId", c => c.Int());
            RenameColumn(table: "dbo.Trainers", name: "InstituteId", newName: "Institute_Id");
            CreateIndex("dbo.Trainers", "Institute_Id");
            AddForeignKey("dbo.Trainers", "Institute_Id", "dbo.Institutes", "Id");
        }
    }
}
