namespace SGI.PI.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembro : DbMigration
    {
        public override void Up()
        {
            SqlFile("./scriptPI_corrigido.sql");
        }

        public override void Down()
        {
        }
    }
}
