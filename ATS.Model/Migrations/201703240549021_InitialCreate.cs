namespace test1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        InstituteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Institutes", t => t.InstituteId, cascadeDelete: true)
                .Index(t => t.InstituteId);
            
            CreateTable(
                "dbo.Institutes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Expartise = c.String(),
                        Code = c.String(),
                        YearofExparience = c.Int(nullable: false),
                        InstituteIed = c.Int(nullable: false),
                        institute_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Institutes", t => t.institute_Id)
                .Index(t => t.institute_Id);
            
            CreateTable(
                "dbo.Trainees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Trainer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trainers", t => t.Trainer_Id)
                .Index(t => t.Trainer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trainees", "Trainer_Id", "dbo.Trainers");
            DropForeignKey("dbo.Trainers", "institute_Id", "dbo.Institutes");
            DropForeignKey("dbo.Branches", "InstituteId", "dbo.Institutes");
            DropIndex("dbo.Trainees", new[] { "Trainer_Id" });
            DropIndex("dbo.Trainers", new[] { "institute_Id" });
            DropIndex("dbo.Branches", new[] { "InstituteId" });
            DropTable("dbo.Trainees");
            DropTable("dbo.Trainers");
            DropTable("dbo.Institutes");
            DropTable("dbo.Branches");
        }
    }
}
