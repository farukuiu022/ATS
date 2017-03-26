namespace test1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trainar_one : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Trainers", new[] { "institute_Id" });
            CreateIndex("dbo.Trainers", "Institute_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Trainers", new[] { "Institute_Id" });
            CreateIndex("dbo.Trainers", "institute_Id");
        }
    }
}
