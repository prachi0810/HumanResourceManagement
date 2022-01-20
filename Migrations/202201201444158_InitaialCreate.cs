namespace HumanResourceList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitaialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HumanReasourceLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DOB = c.DateTime(nullable: false),
                        DepartmentName = c.String(),
                        Status = c.String(),
                        EmpNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HumanReasourceLists");
        }
    }
}
