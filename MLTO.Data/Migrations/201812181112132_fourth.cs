namespace MLTO.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Algorithm", "LearningStyle", c => c.String());
            AlterColumn("dbo.Algorithm", "LearningType", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Algorithm", "LearningType", c => c.String(nullable: false));
            AlterColumn("dbo.Algorithm", "LearningStyle", c => c.String(nullable: false));
        }
    }
}
