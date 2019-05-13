namespace SGI.PI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionarValoresDefaults : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Departamento(Id, Nome, Sigla) Values('1', 'Departamento de Presidência', 'DPRES')");
            Sql("INSERT INTO Departamento(Id, Nome, Sigla) Values('2', 'Departamento de Marketing', 'DMKT')");
            Sql("INSERT INTO Departamento(Id, Nome, Sigla) Values('3', 'Departamento de Projetos', 'DPJ')");
            Sql("INSERT INTO Departamento(Id, Nome, Sigla) Values('4', 'Departamento de Vice-Presidência', 'DVP')");
            Sql("INSERT INTO Departamento(Id, Nome, Sigla) Values('5', 'Departamento de Recursos Humanos', 'DRH')");
            Sql("INSERT INTO Departamento(Id, Nome, Sigla) Values('6', 'Departamento Administrativo Financeiro', 'DAF')");
        }
        
        public override void Down()
        {
        }
    }
}
