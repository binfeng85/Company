using System.Data.Entity.Migrations;

namespace Huang.Company.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EntityFramework.CompanyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CompanyHuang";
            SetSqlGenerator("",new MySql.Data.Entity.MySqlMigrationSqlGenerator());
        }

        protected override void Seed(EntityFramework.CompanyDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
