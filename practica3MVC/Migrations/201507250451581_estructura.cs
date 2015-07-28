namespace practica3MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estructura : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Municipios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        CantidadHabitante = c.Int(nullable: false),
                        Estado_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estadoes", t => t.Estado_Id)
                .Index(t => t.Estado_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Municipios", "Estado_Id", "dbo.Estadoes");
            DropIndex("dbo.Municipios", new[] { "Estado_Id" });
            DropTable("dbo.Municipios");
            DropTable("dbo.Estadoes");
        }
    }
}
