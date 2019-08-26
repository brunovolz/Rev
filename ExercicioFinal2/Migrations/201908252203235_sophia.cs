namespace ExercicioFinal2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sophia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Status = c.String(),
                        CpfCnpj = c.Long(nullable: false),
                        NomeFantasia = c.String(),
                        Cep = c.Int(nullable: false),
                        Endereco = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        Telefone = c.Int(nullable: false),
                        Celular = c.Int(nullable: false),
                        Email = c.String(),
                        Login = c.String(),
                        Senha = c.String(),
                        ConfirmarSenha = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
        }
    }
}
