namespace ExercicioFinal2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class soph : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Telefone", c => c.Long(nullable: false));
            AlterColumn("dbo.Usuarios", "Celular", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Celular", c => c.Int(nullable: false));
            AlterColumn("dbo.Usuarios", "Telefone", c => c.Int(nullable: false));
        }
    }
}
