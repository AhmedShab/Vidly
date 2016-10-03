namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Genre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genre (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genre (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO Genre (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genre (Id, Name) VALUES (4, 'Romance')");
        }

        public override void Down()
        {
        }
    }
}
