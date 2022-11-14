namespace LibPeliculas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ArregloDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clasificacion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pelicula",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClasificacionId = c.Int(nullable: false),
                        GeneroId = c.Int(nullable: false),
                        Nombre = c.String(nullable: false),
                        FechaEstreno = c.DateTime(nullable: false),
                        CantidadMinutos = c.Int(nullable: false),
                        Idioma = c.String(nullable: false),
                        Sinopsis = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genero", t => t.GeneroId)
                .ForeignKey("dbo.Clasificacion", t => t.ClasificacionId)
                .Index(t => t.ClasificacionId)
                .Index(t => t.GeneroId);
            
            CreateTable(
                "dbo.Genero",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(nullable: false),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pelicula", "ClasificacionId", "dbo.Clasificacion");
            DropForeignKey("dbo.Pelicula", "GeneroId", "dbo.Genero");
            DropIndex("dbo.Pelicula", new[] { "GeneroId" });
            DropIndex("dbo.Pelicula", new[] { "ClasificacionId" });
            DropTable("dbo.Genero");
            DropTable("dbo.Pelicula");
            DropTable("dbo.Clasificacion");
        }
    }
}
