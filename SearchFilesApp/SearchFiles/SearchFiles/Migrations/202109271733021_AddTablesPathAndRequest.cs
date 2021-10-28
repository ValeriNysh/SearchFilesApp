namespace SearchFiles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablesPathAndRequest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RequestPaths",
                c => new
                    {
                        PathId = c.Int(nullable: false, identity: true),
                        Path = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PathId);
            
            CreateTable(
                "dbo.RequestStrings",
                c => new
                    {
                        RequestId = c.Int(nullable: false, identity: true),
                        String = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RequestId);
            
            DropTable("dbo.Requests");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        RequestId = c.Int(nullable: false, identity: true),
                        Path = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RequestId);
            
            DropTable("dbo.RequestStrings");
            DropTable("dbo.RequestPaths");
        }
    }
}
