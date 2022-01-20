namespace HumanResourceList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitaialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HumanReasourceLists", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HumanReasourceLists", "Email");
        }
    }
}
