namespace ExercicioFinal2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class caneta : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "CpfCnpj", c => c.String());
            AlterColumn("dbo.Usuarios", "Cep", c => c.String());
            AlterColumn("dbo.Usuarios", "Telefone", c => c.String());
            AlterColumn("dbo.Usuarios", "Celular", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Celular", c => c.Long(nullable: false));
            AlterColumn("dbo.Usuarios", "Telefone", c => c.Long(nullable: false));
            AlterColumn("dbo.Usuarios", "Cep", c => c.Int(nullable: false));
            AlterColumn("dbo.Usuarios", "CpfCnpj", c => c.Long(nullable: false));
        }
    }
}
