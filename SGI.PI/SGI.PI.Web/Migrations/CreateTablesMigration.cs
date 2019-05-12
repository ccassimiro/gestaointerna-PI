using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace SGI.PI.Web.Migrations
{
    public partial class CreateTablesMigration : DbMigration
    {
        public override void Up()
        {
            SqlFile("./resources/scriptPI_corrigido.sql");
        }
    }
}