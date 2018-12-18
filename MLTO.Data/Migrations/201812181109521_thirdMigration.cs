namespace MLTO.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirdMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Algorithm", "LearningStyle", c => c.String(nullable: false));
            AddColumn("dbo.Algorithm", "LearningType", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Algorithm", "LearningType");
            DropColumn("dbo.Algorithm", "LearningStyle");
        }
    }
}
