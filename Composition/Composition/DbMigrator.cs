namespace Composition
{
    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            // using _logger to call Log method of Logger class
            _logger.Log("We are migrating ....");
        }
    }
}
