namespace SGI.PI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionarCargosENucleos : DbMigration
    {
        public override void Up()
        {
            //Inser��o de alguns n�cleos para teste (ao final ser�o cadastrados os demais);
            Sql("INSERT INTO Nucleo(Id, Nome, Sigla, DepartamentoId) Values('1', 'Nucleo de Projetos de Computa��o', 'NPCP', '3')");
            Sql("INSERT INTO Nucleo(Id, Nome, Sigla, DepartamentoId) Values('2', 'Nucleo de Projetos de El�trica', 'NPE', '3')");
            Sql("INSERT INTO Nucleo(Id, Nome, Sigla, DepartamentoId) Values('3', 'Nucleo de Projetos de Controle e Automa��o', 'NPCA', '3')");

            //Inser��o de alguns cargos (ao final ser�o cadastrados os demais);
            Sql("INSERT INTO Cargo(Id, Nome, Lideranca) Values('1', 'Gerente', '1')");
            Sql("INSERT INTO Cargo(Id, Nome, Lideranca) Values('2', 'Projetista', '0')");
            Sql("INSERT INTO Cargo(Id, Nome, Lideranca) Values('3', 'Diretor', '1')");


        }
        
        public override void Down()
        {
        }
    }
}
