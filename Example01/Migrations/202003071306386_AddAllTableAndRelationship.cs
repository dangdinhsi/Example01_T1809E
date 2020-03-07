namespace Example01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAllTableAndRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Punishments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        RollNumber = c.String(nullable: false, maxLength: 128),
                        PunishmentId = c.Int(nullable: false),
                        CountP = c.Int(nullable: false),
                        TimeP = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RollNumber)
                .ForeignKey("dbo.Punishments", t => t.PunishmentId, cascadeDelete: true)
                .Index(t => t.PunishmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "PunishmentId", "dbo.Punishments");
            DropIndex("dbo.Students", new[] { "PunishmentId" });
            DropTable("dbo.Students");
            DropTable("dbo.Punishments");
        }
    }
}
